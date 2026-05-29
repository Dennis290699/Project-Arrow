\subsection{APIs y SDKs}

El desarrollo del proyecto aprovecha las herramientas integradas en el motor de juego y un conjunto de librerías complementarias estándar para asegurar el rendimiento y el control de versiones:

\subsubsection*{Unity Engine (LTS)}

Se utiliza la versión de largo soporte \textbf{Unity 6 LTS}. El motor provee las APIs nativas esenciales para el juego:
\begin{itemize}
    \item \textbf{UnityEngine.Physics2D:} APIs para la manipulación de fuerzas en el Rigidbody2D del jugador, trazado de Raycasts para detectar el suelo e interacciones con triggers mediante \texttt{OnTriggerEnter2D}.
    \item \textbf{UnityEngine.SceneManagement:} API para gestionar la carga síncrona y asíncrona de niveles y menús.
    \item \textbf{UnityEngine.UI:} APIs para gestionar eventos de interacción en botones e interactuar con componentes Canvas.
\end{itemize}

\subsubsection*{TextMeshPro}

Se integra \textbf{TextMeshPro (TMP)} como el estándar para renderizado de textos en pantalla. TMP reemplaza el sistema de texto clásico de Unity, utilizando la técnica \emph{Signed Distance Field (SDF)} para mantener fuentes nítidas y escalables en cualquier resolución de pantalla, siendo clave para el estilo pixel art y la legibilidad de la UI de mejoras y de los textos flotantes de daño.

\subsubsection*{Cinemachine}

Se emplea el paquete \textbf{Cinemachine} de Unity para delegar el comportamiento y seguimiento de la cámara:
\begin{itemize}
    \item \textbf{Virtual Camera:} Sigue la posición del transform de Sir Gareth de forma automática.
    \item \textbf{Framing Transposer:} Configura límites de amortiguación (\emph{Dead Zone} y \emph{Soft Zone}) para suavizar los movimientos de cámara durante saltos rápidos o caídas.
    \item \textbf{Cinemachine Confiner 2D:} Utiliza un componente \texttt{PolygonCollider2D} en la escena para delimitar los bordes físicos del nivel, evitando que la cámara muestre áreas vacías del fondo parallax.
\end{itemize}

\subsubsection*{Git Large File Storage (LFS)}

El repositorio en GitHub utiliza la extensión \textbf{Git LFS} para gestionar de forma eficiente los archivos binarios de gran tamaño del proyecto, tales como:
\begin{itemize}
    \item Hojas de sprites (\emph{Sprite Sheets}) de personajes y enemigos en formato PNG.
    \item Archivos de sonido de alta definición (\texttt{.wav} y \texttt{.mp3}) para pistas musicales y efectos.
    \item Prefabs complejos y assets de fuentes tipográficas.
\end{itemize}
Git LFS evita la sobrecarga del historial de Git descargando únicamente los punteros de los archivos en lugar de los binarios pesados en cada confirmación de cambio.

\subsubsection*{Middleware de Terceros: LeanTween}

Para el suavizado de movimientos e interfaces por código sin coste para la CPU, el proyecto integra el paquete de terceros \textbf{LeanTween}:
\begin{itemize}
    \item \textbf{Descripción:} Es una librería de interpolación liviana que calcula transformaciones matemáticas directas sobre variables float y vectores en memoria de forma secuencial.
    \item \textbf{Uso en el proyecto:} Controla la interpolación de posiciones verticales y opacidades de los paneles de UI de derrota (\texttt{setEaseOutBounce}) y de victoria (\texttt{setEaseInOutBack}), la animación de los textos flotantes de daño y el movimiento cíclico entre nodos de las sierras mecánicas.
\end{itemize}
