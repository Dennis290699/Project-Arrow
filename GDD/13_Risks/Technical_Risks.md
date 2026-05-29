\subsection{Riesgos técnicos}

En esta sección se identifican los principales riesgos tecnológicos que pueden afectar el desarrollo del prototipo de \emph{Chronicles of the Cursed Knight}, junto con sus respectivas estrategias de mitigación.

\subsubsection*{Conflictos de fusión (Merge Conflicts) en Unity}

Las escenas (\texttt{.unity}) y los prefabricados (\texttt{.prefab}) de Unity son archivos en formato serializado YAML que resultan extremadamente difíciles de fusionar de forma automática en Git. Si varios integrantes del equipo modifican el mismo archivo simultáneamente, se pueden generar conflictos que causen pérdida de trabajo o corrupción de archivos.

\textbf{Mitigación:}
\begin{itemize}
    \item Cada integrante del equipo trabajará de forma aislada en escenas de prueba separadas (por ejemplo, \texttt{Level\_Denis}, \texttt{Level\_Dev2}).
    \item Solo un integrante designado como integrador se encargará de importar y acoplar los prefabs probados en la escena principal del juego (\texttt{SampleScene}).
    \item Se exigirá realizar commits pequeños, frecuentes y enfocados en un único asset o script.
\end{itemize}

\subsubsection*{Problemas de rendimiento por instanciación constante}

La instanciación y destrucción repetitiva de proyectiles (flechas), efectos de partículas y textos flotantes de daño mediante los métodos \texttt{Instantiate} y \texttt{Destroy} de Unity puede saturar el recolector de basura (Garbage Collector), provocando microcongelamientos o caídas en la tasa de cuadros por segundo (\emph{Framerate Drop}) en equipos de gama media.

\textbf{Mitigación:}
\begin{itemize}
    \item Si las pruebas iniciales evidencian problemas de rendimiento, se reemplazará la instanciación directa por un sistema de \textbf{Object Pooling} para proyectiles y textos flotantes. Este sistema desactivará y reutilizará objetos existentes en memoria en lugar de eliminarlos.
    \item Se optimizará el uso de animaciones sencillas mediante la librería LeanTween en lugar de usar controladores de animación basados en Animator clásicos de Unity para elementos decorativos o cíclicos simples.
\end{itemize}

\subsubsection*{Fallas en la integración de subsistemas modulares}

El desarrollo paralelo de los sistemas de movimiento, IA de enemigos, HUD de UI y audio dinámico incrementa el riesgo de fallas de compilación o comportamientos inesperados cuando los scripts se integren en una única rama.

\textbf{Mitigación:}
\begin{itemize}
    \item Se implementará una política de integración continua mediante pruebas semanales obligatorias en la rama de desarrollo (\texttt{dev}).
    \item Toda función global expuesta por los Singleton managers (como el control de puntuación del \texttt{GameManager} o reproducción de sonido en \texttt{AudioManager}) se documentará con firmas claras y comentarios de código.
\end{itemize}
