\subsection{HUD (Heads-Up Display)}

El HUD de \emph{Chronicles of the Cursed Knight} provee información crítica en tiempo real de forma clara y no intrusiva durante el juego. La interfaz está diseñada para permanecer fija en las esquinas de la pantalla, asegurando una visibilidad óptima de los elementos jugables.

\subsubsection*{Configuración del Canvas de Interfaz}

Todos los elementos de la interfaz de usuario se gestionan dentro de un componente \texttt{Canvas} de Unity configurado con los siguientes parámetros técnicos:
\begin{itemize}
    \item \textbf{Render Mode:} \texttt{Screen Space - Overlay}, asegurando que la UI se renderice siempre en primer plano sobre cualquier elemento tridimensional o de parallax.
    \item \textbf{Canvas Scaler Mode:} \texttt{Scale With Screen Size}, con una resolución de referencia estándar de \textbf{1920x1080 píxeles}.
    \item \textbf{Screen Match Mode:} \texttt{Match Width Or Height} (establecido en un coeficiente de $0.5$ para equilibrar el escalado horizontal y vertical en relaciones de aspecto comunes de PC como 16:9 y 16:10).
\end{itemize}

\subsubsection*{Contadores principales en pantalla}

El HUD se compone de dos módulos principales situados en los extremos superiores de la pantalla:
\begin{itemize}
    \item \textbf{Indicador de Salud (Esquina Superior Izquierda):} Representa los contenedores de corazones ($HP$) del jugador en unidades enteras. Utiliza una fila horizontal de imágenes que se activan o desactivan según el valor de la variable de salud. Si el jugador adquiere un corazón en el menú de Elara, el Canvas instancia dinámicamente un nuevo icono de corazón en la fila.
    \item \textbf{Contador de Almas / Diamantes (Esquina Superior Derecha):} Muestra un icono estático del Diamante de Almas junto a un campo de texto dinámico de alta definición (\texttt{TextMeshProUGUI}). Este campo se suscribe a los cambios de la variable \texttt{currentDiamonds} del jugador para actualizar el contador numérico de forma inmediata tras recolectar almas.
\end{itemize}

\subsubsection*{Sistema de textos flotantes de daño (Damage Text)}

Para dar una retroalimentación de combate satisfactoria y cuantificable, el juego incluye un sistema dinámico de textos flotantes de daño gestionado por el script \texttt{DamageTextManager.cs}:

\begin{itemize}
    \item \textbf{Lógica de Instanciación:} Cuando el jugador hiere a un enemigo (restando $1$ HP), el controlador del enemigo invoca al \texttt{DamageTextManager}, pasando la posición espacial actual en el mundo ($\vec{p}_{enemy}$) y el valor de daño infligido.
    \item \textbf{Estructura del Prefab:} El texto flotante es un objeto prefabricado (\emph{Prefab}) que contiene un componente \texttt{TextMeshPro} configurado para renderizarse directamente en el espacio de juego (\texttt{World Space}), alineando la fuente con el estilo pixel art del juego.
    \item \textbf{Interpolación y Animación (LeanTween):} Al instanciarse, el script aplica una interpolación geométrica y visual al prefab durante una ventana de $0.6$ segundos:
    \begin{itemize}
        \item \textbf{Movimiento vertical:} Desplaza la posición local en el eje Y hacia arriba en $1.5$ unidades mediante \texttt{LeanTween.moveY()} con una curva de desaceleración (\texttt{easeOutQuad}).
        \item \textbf{Transición de opacidad:} Desvanece el canal alfa del texto de $1.0$ a $0.0$ de forma lineal para lograr un efecto de desvanecimiento suave (\emph{Fade Out}).
        \item \textbf{Escalado sutil:} Aplica un pulso rápido de escala (\texttt{scale} de $0.8f$ a $1.2f$ y de vuelta a $1.0f$) en los primeros $0.1$ segundos para simular un impacto fuerte.
    \end{itemize}
    \item \textbf{Recolección de Basura y Destrucción:} Una vez transcurridos los $0.6$ segundos de la animación, el script invoca internamente \texttt{Destroy(gameObject)} para liberar la memoria de Unity y evitar fugas de rendimiento en combates intensos.
\end{itemize}