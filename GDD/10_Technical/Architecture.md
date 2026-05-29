\subsection{Arquitectura}

La arquitectura de \emph{Chronicles of the Cursed Knight} está diseñada bajo un enfoque modular y desacoplado, utilizando el sistema basado en componentes nativo de Unity 6. Se prioriza la optimización del rendimiento y el control estricto del ciclo de vida del juego mediante managers centralizados.

\subsubsection*{Patrones de diseño implementados}

\begin{itemize}
    \item \textbf{Patrón Singleton:} Se aplica de forma estricta en los sistemas globales de control de flujo (\texttt{GameManager}, \texttt{AudioManager}, \texttt{SceneManagement} y \texttt{CameraShake}). Esto garantiza una única instancia activa en memoria a lo largo de la ejecución del software y provee un punto de acceso global mediante la sintaxis estática \texttt{Instance}.
    \item \textbf{Desacoplamiento por Eventos de Animación:} Para evitar dependencias directas entre componentes físicos y lógicos, las ejecuciones críticas como la instanciación de proyectiles hostiles y del jugador (\texttt{FireArrow()}) se ejecutan mediante eventos incrustados en los fotogramas de los clips de animación, optimizando los ciclos de procesamiento del hilo principal.
\end{itemize}

\subsubsection*{Subsistemas y Arquitectura de Scripts (Managers)}

La ejecución del juego se divide en módulos especializados con responsabilidades únicas:

\paragraph{A. Control de Estado y Progresión (GameManager.cs)}
Actúa como el núcleo lógico de la partida. Gestiona variables globales de progresión (como la recopilación de llaves, \texttt{public int key}) e intercepta los estados críticos de finalización del juego para desplegar los elementos visuales correspondientes:
\begin{itemize}
    \item \textbf{Game Over:} Detiene el flujo estándar de la partida, invoca la melodía de derrota desde el sistema de sonido y utiliza LeanTween para desplazar el panel de derrota (\texttt{gameOverUIBG}) desde una posición externa hacia el centro de la pantalla ($Y = 0f$) en un lapso de $0.8$ segundos, aplicando una ecuación de amortiguación elástica (\texttt{setEaseOutBounce()}).
    \item \textbf{Victory UI:} Controla la transición del panel de victoria (\texttt{victoryUIBG}), desplazándolo verticalmente mediante una curva de interpolación suavizada (\texttt{setEaseInOutBack()}) tras verificar la interacción con el trigger de salida.
\end{itemize}

\paragraph{B. Sistema de Audio Dinámico (AudioManager.cs y Sound.cs)}
El sistema de sonido opera de forma automatizada mediante una arquitectura basada en datos:
\begin{itemize}
    \item \textbf{Estructura de Datos (Sound.cs):} Clase contenedora con la etiqueta \texttt{[Serializable]}, lo que permite su parametrización directa desde el Inspector de Unity. Almenta de manera encapsulada las propiedades individuales de cada pista de audio: archivo binario (\texttt{AudioClip}), identificador alfanumérico (\texttt{string name}), volumen normalizado (\texttt{float volume} acotado mediante un atributo \texttt{[Range(0f, 1f)]}), bandera de bucle (\texttt{bool loop}) y una referencia oculta al componente emisor físico (\texttt{AudioSource}).
    \item \textbf{Motor de Audio (AudioManager.cs):} Clase Singleton persistente que sobreescribe el ciclo de vida de las escenas utilizando \texttt{DontDestroyOnLoad}, impidiendo su destrucción al cambiar de nivel. Durante la fase de inicialización (\texttt{Awake}), itera sobre la colección de estructuras \texttt{Sound}, inyectando un componente \texttt{AudioSource} por cada pista dentro del objeto contenedor. La reproducción se invoca globalmente mediante la firma de método estático \texttt{AudioManager.Instance.PlaySound(string name)}.
\end{itemize}

\paragraph{C. Control de Escenas (SceneManagement.cs)}
Abstrae y encapsula las operaciones nativas del framework \texttt{UnityEngine.SceneManagement} para mitigar riesgos de llamadas erróneas o corrupción de índices de compilación:
\begin{itemize}
    \item Intermedia las llamadas lógicas de botones reproduciendo una señal auditiva universal (\texttt{"Click"}) previa a cualquier carga de entorno.
    \item Estructura las cargas asíncronas dirigiendo el flujo desde el menú principal hacia la escena de cinemática narrativa (\texttt{"StoryScene"}), y posteriormente hacia los entornos de simulación física (\texttt{"SampleScene"}).
    \item Provee subrutinas limpias para el reinicio del nivel activo recuperando dinámicamente el identificador de compilación en tiempo de ejecución (\texttt{SceneManager.GetActiveScene().buildIndex}), así como el cierre seguro de la aplicación mediante \texttt{Application.Quit()}.
\end{itemize}

\paragraph{D. Cinemáticas e Interpolación por Código (StoryManager.cs)}
El control de la narrativa interactiva utiliza la librería LeanTween para manipular canales alfa y coeficientes de visibilidad en pantalla sin coste de procesamiento de CPU:
\begin{itemize}
    \item \textbf{Fades de Pantalla:} Modifica la opacidad de los componentes de interfaz de tipo \texttt{CanvasGroup} mediante la función \texttt{LeanTween.alphaCanvas()}, operando con curvas de interpolación cuadráticas (\texttt{easeOutQuad} y \texttt{easeInQuad}) en una ventana temporal paramétrica (\texttt{fadeDuration}).
    \item \textbf{Efecto Máquina de Escribir:} Coordina la inyección secuencial de caracteres (\texttt{char}) en un componente de texto de alta definición \texttt{TextMeshProUGUI}, cronometrando los retardos fijos a través de la variable \texttt{typingSpeed} mediante una corrutina y permitiendo la omisión (\emph{Skip}) inmediata del texto al presionar una tecla.
\end{itemize}

\paragraph{E. Movimiento de Obstáculos Dinámicos (SawMover.cs)}
Las trampas de sierras móviles implementan un sistema de movimiento autónomo basado en nodos para prescindir de la llamada costosa del método \texttt{Update()} en cada frame:
\begin{itemize}
    \item \textbf{Lógica de Trayectoria:} Procesa un arreglo dinámico de vectores de posición (\texttt{public Transform[] points}) asignados desde el editor de Unity.
    \item \textbf{Bucle Infinito:} Traslada físicamente el objeto hacia el nodo objetivo mediante el método estático \texttt{LeanTween.move()} dentro de una ventana temporal estricta (\texttt{moveTime}), aplicando un suavizado cinemático \texttt{setEaseOutBack()} en los extremos del nodo. Al completarse el recorrido, se ejecuta el callback \texttt{setOnComplete(MoveToNextPoint)} para incrementar el índice del nodo y reiniciar el bucle de forma indefinida.
\end{itemize}

\subsubsection*{Arquitectura de Scripts de Gameplay}

El flujo interactivo y de físicas de la partida está controlado por una colección desacoplada de scripts asociados a los prefabs de juego:

\begin{itemize}
    \item \textbf{\texttt{PlayerController.cs}:} Gobierna las físicas de Sir Gareth. Captura los inputs del teclado (\texttt{Horizontal}, \texttt{Space}) para aplicar fuerzas en el componente \texttt{Rigidbody2D} utilizando \texttt{fixedDeltaTime} (Velocidad horizontal = $5f$, Impulso de salto = $7f$). Gestiona el doble salto y los frames de invulnerabilidad (\texttt{IFrames}) en la recepción de daño.
    \item \textbf{\texttt{Arrow.cs}:} Controla las flechas físicas instanciadas por el jugador. Aplica una fuerza horizontal inicial constante en su \texttt{Rigidbody2D}. Posee un disparador de colisiones (\texttt{OnTriggerEnter2D}) para aplicar daño al enemigo (restando vida en \texttt{EnemyBehavior}) y desactivarse de vuelta al Object Pool al impactar con la geometría (\texttt{Ground}).
    \item \textbf{\texttt{EnemyBehavior.cs}:} Controla a los enemigos mediante una Máquina de Estados Finitos (FSM) discreta (Patrulla, Alerta, Persecución, Daño, Muerte). Administra los contenedores de vida del enemigo y dispara el incremento de diamantes de almas en el \texttt{GameManager} al morir.
    \item \textbf{\texttt{UpgradeManager.cs}:} Controla el menú interactivo del checkpoint (Eco de Elara). Verifica la cantidad de almas en el \texttt{GameManager} y modifica las variables del jugador ($HP_{max}$ y daño de flechas) al gastar diamantes.
\end{itemize}

\subsubsection*{Diagrama de Flujo de Datos y Clases}

La siguiente estructura representa el flujo de comunicación y dependencias de datos entre las clases principales del videojuego durante un bucle de juego típico:

\begin{verbatim}
       [Teclado/Mouse Inputs]
                 │
                 ▼
       ┌───────────────────┐            ┌──────────────────┐
       │ PlayerController  ├───────────►│   UpgradeManager │
       └─────────┬─────────┘            └────────┬─────────┘
                 │ (Instancia)                   │ (Lee/Escribe)
                 ▼                               ▼
       ┌───────────────────┐            ┌──────────────────┐
       │     Arrow.cs      │            │   GameManager    │
       └─────────┬─────────┘            └────────▲─────────┘
                 │ (Aplica Daño)                 │ (Suma Diamantes)
                 ▼                               │
       ┌───────────────────┐                     │
       │  EnemyBehavior    ├─────────────────────┘
       └───────────────────┘ (Al morir)
\end{verbatim}

\subsubsection*{Sistema de Capas y Matriz de Colisiones (Physics 2D)}

Para optimizar el rendimiento del motor de físicas 2D y evitar cálculos de contacto innecesarios, los objetos del juego están distribuidos en las siguientes capas lógicas (\emph{Layers}):

\begin{itemize}
    \item \textbf{Player:} Contiene únicamente a Sir Gareth. Interactúa físicamente con \texttt{Ground}, \texttt{Enemy}, \texttt{Traps} y \texttt{EnemyProjectile}.
    \item \textbf{Enemy:} Contiene a las IAs (Ninjas, Arqueros, Esqueletos). Interactúa físicamente con \texttt{Ground} y \texttt{PlayerProjectile}.
    \item \textbf{Traps:} Peligros del entorno (Pinchos, Sierras móviles). Interactúa exclusivamente con la capa \texttt{Player}.
    \item \textbf{PlayerProjectile:} Flechas disparadas por Sir Gareth. Colisionan con las capas \texttt{Enemy} y \texttt{Ground} (para destruirse al impactar muros).
    \item \textbf{EnemyProjectile:} Proyectiles disparados por arqueros enemigos. Colisionan con las capas \texttt{Player} y \texttt{Ground}.
    \item \textbf{Ground:} El entorno físico (Tilemaps de colisión). Interactúa con todas las capas móviles del juego.
\end{itemize}

\emph{Nota de Optimización:} La capa \texttt{PlayerProjectile} se configura en la matriz de colisiones de Unity para ignorar por completo la capa \texttt{Player}, garantizando que Sir Gareth no colisione con sus propios proyectiles al instanciarlos.
