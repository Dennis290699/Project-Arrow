\section{APIs, SDKs y Paquetes}

\subsection{Unity 6 LTS}

Unity 6 LTS constituye el motor principal del proyecto. Se utiliza por su soporte para desarrollo 2D, herramientas de fisica, sistema de animacion, manejo de escenas, exportacion multiplataforma y flujo de trabajo ampliamente documentado.

\subsection{Cinemachine}

Cinemachine se emplea para seguimiento suave de camara, configuracion de \emph{Dead Zones}, transiciones y efectos de sacudida mediante Cinemachine Impulse. Su uso permite mejorar la presentacion sin construir desde cero un sistema de camara complejo.

\subsection{TextMeshPro}

TextMeshPro se utiliza para renderizar textos nitidos en interfaz, dialogos, contadores y textos flotantes. Su calidad visual es superior al sistema de texto clasico de Unity y resulta especialmente util en resoluciones variables.

\subsection{Git y GitHub}

El repositorio se aloja en GitHub. Git se utiliza para control de versiones, trazabilidad de cambios, trabajo por ramas e integracion del equipo. La estructura de ramas propuesta incluye \texttt{main}, \texttt{dev} y ramas de caracteristicas como \texttt{feature/combate} o \texttt{feature/ui}.

\subsection{Git LFS}

Git LFS es obligatorio para archivos pesados como \texttt{.png}, \texttt{.wav}, \texttt{.mp3} y \texttt{.psd}. Su uso evita saturar el historial del repositorio y mejora la gestion de recursos binarios.

