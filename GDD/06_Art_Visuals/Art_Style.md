\subsection{Estilo gráfico}

\subsubsection*{Dirección artística}

<<<<<<< HEAD
\emph{Chronicles of the Cursed Knight} emplea un estilo visual basado en pixel art inspirado en producciones de 16 y 32 bits, combinado con técnicas modernas de iluminación, partículas y composición multicapa.

La dirección artística busca equilibrar atmósfera gótica, claridad mecánica y coherencia narrativa. Aunque el entorno utiliza una paleta predominantemente oscura y melancólica, los personajes, enemigos y elementos interactivos deben conservar suficiente contraste visual para garantizar lectura inmediata durante la jugabilidad.

La estética general prioriza escenarios decadentes, arquitectura medieval deteriorada y elementos sobrenaturales asociados con corrupción espiritual y ruinas abandonadas.

\subsubsection*{Lenguaje visual}

El diseño del entorno utiliza formas angulares, estructuras fragmentadas y siluetas desgastadas para transmitir decadencia y pérdida. Las zonas afectadas por la corrupción presentan grietas luminosas, vegetación marchita, niebla tenue y deformaciones progresivas de la arquitectura.

En contraste, los elementos vinculados al Eco de Elara utilizan iluminación suave, partículas flotantes y colores fríos o dorados para representar calma, memoria y protección espiritual.

Este contraste visual permite diferenciar claramente las áreas seguras de las zonas dominadas por la corrupción.

\subsubsection*{Formato visual}

La relación de aspecto principal corresponde a 16:9. Se recomienda utilizar una cámara ortográfica con parámetros consistentes y herramientas de \emph{Pixel Perfect} para conservar nitidez en sprites, tiles y animaciones.

El escalado debe evitar deformaciones y preservar la lectura de siluetas, especialmente durante secuencias de combate o desplazamiento rápido.

La interfaz y los efectos visuales deben adaptarse al estilo pixel art sin romper coherencia estética.

\subsubsection*{Parallax 2.5D}

La sensación de profundidad se construye mediante un sistema de parallax multicapa. El escenario se divide en capas de fondo, entorno medio y primer plano, cada una con velocidades de desplazamiento distintas respecto al movimiento del jugador.

Las capas lejanas incluyen cielo, montañas y estructuras del castillo, mientras que los planos cercanos contienen muros, columnas, vegetación y elementos decorativos.

Este enfoque permite generar profundidad visual sin abandonar la jugabilidad bidimensional.

La implementación visual busca reforzar la sensación de aislamiento, escala y decadencia del reino mediante fondos con predominancia de tonos fríos y desaturados.

\subsubsection*{Iluminación y atmósfera}

La iluminación cumple una función tanto estética como narrativa. Las zonas seguras presentan fuentes de luz cálidas y relativamente estables, mientras que las áreas corrompidas utilizan iluminación tenue, contrastes agresivos y efectos de sombra parcial.

Se contempla el uso de niebla ligera, partículas ambientales y variaciones de color para reforzar la sensación de aislamiento y deterioro.

Los efectos luminosos asociados con magia, almas y reliquias deben destacar dentro del escenario para atraer la atención del jugador y reforzar la identidad sobrenatural del mundo.

\subsubsection*{Efectos visuales}

Los efectos visuales contemplados incluyen partículas al impactar enemigos, polvo al aterrizar después de un salto elevado, destellos al recolectar Diamantes de Almas y emisiones de luz en objetos mágicos o rituales.

Para reforzar impactos importantes se propone el uso de \emph{Screen Shake} mediante Cinemachine Impulse, combinado con efectos breves de congelamiento visual (\emph{hit stop}) durante ataques significativos.

Estos recursos buscan mejorar la percepción de impacto, respuesta y peso mecánico.

Asimismo, se considera el uso de pequeños destellos de daño, variaciones temporales de iluminación y efectos de desenfoque leve durante habilidades o encuentros importantes.

\subsubsection*{Criterios de legibilidad}

La legibilidad visual constituye una prioridad de diseño. Los elementos peligrosos deben presentar contraste suficiente y formas reconocibles incluso en escenas oscuras o con múltiples efectos visuales.

Las plataformas deben diferenciarse claramente del decorado, los enemigos deben conservar siluetas identificables y los objetos recolectables deben atraer la mirada sin saturar visualmente la escena.

La composición general busca evitar ruido visual excesivo que pueda afectar la precisión del jugador durante exploración o combate.

El personaje principal debe conservar prioridad visual respecto al entorno mediante contraste cromático, separación de planos y posibles efectos de iluminación sutil alrededor de la silueta.
=======
La dirección artística de \textit{Chronicles of the Cursed Knight} se fundamenta en una estética \textit{pixel art} inspirada en videojuegos clásicos de 16 y 32 bits, combinando elementos visuales retro con técnicas modernas de composición y ambientación. El objetivo principal es construir un mundo fantástico con una identidad visual melancólica y misteriosa, capaz de transmitir sensación de aventura, decadencia y exploración.

El apartado visual debe mantener equilibrio entre atractivo artístico y claridad jugable. Cada elemento presente en pantalla debe cumplir una función visual específica, evitando saturación de detalles que dificulten la lectura del escenario o las acciones del jugador. La estética general se apoya en escenarios naturales, ruinas antiguas, arquitectura medieval fantástica y entornos deteriorados que refuercen la narrativa del videojuego.

La paleta de colores debe variar según la zona del nivel, utilizando tonos fríos y apagados para áreas abandonadas o peligrosas, mientras que elementos mágicos, objetos importantes y efectos especiales pueden incorporar colores brillantes o contrastantes para captar atención inmediata.

El personaje principal, Sir. Garet, debe poseer un diseño reconocible incluso a distancia, utilizando una silueta clara, capa distinguible y elementos visuales asociados a un caballero arquero élfico. Los enemigos y objetos interactivos deben diferenciarse fácilmente tanto por color como por forma para favorecer la identificación rápida durante la jugabilidad.

\subsubsection*{Inspiración visual y referencias}

La propuesta visual toma inspiración de videojuegos clásicos y modernos del género plataformas y acción en 2D, especialmente aquellos que combinan exploración, combate y ambientación fantástica oscura. Entre las principales referencias visuales se encuentran:

\begin{itemize}
    \item Escenarios medievales y fantasticos con iluminación ambiental tenue.
    \item Pixel art detallado con animaciones fluidas.
    \item Fondos multicapa que generan sensación de profundidad.
    \item Contraste entre ambientes sombríos y elementos mágicos brillantes.
    \item Interfaces minimalistas integradas con la estética retro.
\end{itemize}

El objetivo no es replicar directamente otros videojuegos, sino construir una identidad visual propia que combine nostalgia clásica con una presentación moderna y coherente.

\subsubsection*{Formato visual}

La relación de aspecto principal del videojuego será \textbf{16:9}, adaptándose a resoluciones modernas sin perder coherencia visual. El sistema gráfico debe priorizar nitidez y estabilidad de imagen para evitar distorsiones frecuentes en proyectos \textit{pixel art}.

Dentro de Unity se recomienda utilizar:

\begin{itemize}
    \item Cámara ortográfica para conservar perspectiva bidimensional.
    \item Herramientas \emph{Pixel Perfect Camera}.
    \item Resolución base escalable manteniendo proporciones enteras.
    \item Sprites configurados sin filtrado borroso (\texttt{Point Filter}).
    \item Tiles organizados mediante \texttt{Tilemaps}.
\end{itemize}

El escalado visual debe preservar la lectura de siluetas y evitar deformaciones en personajes, plataformas y efectos. Asimismo, las animaciones deben mantener fluidez sin comprometer el estilo retro característico del proyecto.

\subsubsection*{Diseño de escenarios}

Los escenarios deben transmitir sensación de aventura y progresión dentro de un mundo fantástico en decadencia. Cada zona del nivel necesita identidad visual propia, diferenciándose mediante arquitectura, color, iluminación y composición ambiental.

Los \textit{Jardines Marchitos} deben representar naturaleza deteriorada, vegetación seca y estructuras abandonadas, utilizando tonos verdes apagados, grises y marrones oscuros. Las \textit{Mazmorras del Eco} deben enfatizar encierro y misterio mediante iluminación tenue, paredes húmedas y espacios estrechos. Finalmente, la \textit{Torre del Hechicero} debe reflejar poder mágico y peligro, incorporando símbolos arcanos, energía luminosa y estructuras verticales imponentes.

El diseño del entorno no solo cumple función estética, sino también jugable. Los caminos principales deben guiar visualmente al jugador mediante composición del escenario, iluminación y distribución de plataformas.

\subsubsection*{Parallax 2.5D}

Para incrementar sensación de profundidad y dinamismo visual, el videojuego implementará un sistema de \textit{parallax scrolling} con enfoque 2.5D. Este efecto se logra desplazando múltiples capas del fondo a diferentes velocidades respecto al movimiento del jugador.

Las capas principales contempladas incluyen:

\begin{itemize}
    \item Fondo lejano: cielo, luna, niebla o paisajes distantes.
    \item Plano intermedio: montañas, castillos o estructuras grandes.
    \item Plano cercano: ruinas, árboles, columnas y elementos ambientales.
\end{itemize}

Cada capa debe moverse de forma proporcional a su profundidad, creando ilusión espacial sin abandonar la jugabilidad bidimensional. Este recurso visual ayuda a enriquecer escenarios y aumentar percepción de escala dentro del nivel.

Adicionalmente, pueden incorporarse elementos animados en segundo plano, como lluvia, partículas flotantes o movimiento de vegetación, para incrementar sensación de vida en el entorno.

\subsubsection*{Animaciones}

Las animaciones deben transmitir claridad y personalidad sin perder coherencia con el estilo \textit{pixel art}. Sir. Garet requiere animaciones fluidas para:

\begin{itemize}
    \item Movimiento y desplazamiento.
    \item Salto y caída.
    \item Ataques con arco.
    \item Recepción de daño.
    \item Interacciones especiales.
\end{itemize}

Los enemigos también deben poseer patrones de animación claramente identificables que permitan anticipar ataques y comportamientos. Las transiciones entre animaciones deben mantenerse suaves para mejorar percepción de control y respuesta del personaje.

\subsubsection*{Efectos visuales}

Los efectos visuales cumplen una función importante para reforzar impacto, interacción y elementos mágicos dentro del videojuego. Entre los efectos principales contemplados se incluyen:

\begin{itemize}
    \item Partículas al golpear enemigos.
    \item Polvo al aterrizar tras saltos altos.
    \item Destellos al recolectar \textit{Diamantes de Almas}.
    \item Emisiones de luz en objetos mágicos.
    \item Rastros luminosos en proyectiles.
    \item Pequeñas explosiones o fragmentos al destruir enemigos.
\end{itemize}

Para reforzar acciones importantes, se propone implementar efectos de \emph{Screen Shake} utilizando \texttt{Cinemachine Impulse}. Este recurso puede utilizarse durante impactos fuertes, derrotas de jefes o eventos importantes para incrementar sensación de fuerza y dramatismo.

Los efectos deben mantenerse moderados para no afectar la legibilidad general del escenario ni distraer al jugador durante secuencias intensas.

\subsubsection*{Iluminación y atmósfera}

Aunque el videojuego utiliza una estética retro, la iluminación puede aprovechar herramientas modernas para mejorar ambientación y profundidad visual. Se recomienda utilizar luces 2D dinámicas en zonas específicas, especialmente en:

\begin{itemize}
    \item Cristales mágicos.
    \item Hechizos o energía arcana.
    \item Áreas narrativamente importantes.
\end{itemize}

La iluminación debe utilizarse como recurso narrativo y jugable, guiando la atención del jugador hacia zonas importantes del escenario.

\subsubsection*{Criterios de legibilidad}

La claridad visual representa una prioridad fundamental dentro del diseño gráfico del videojuego. Todos los elementos interactivos deben diferenciarse claramente del fondo y conservar lectura inmediata incluso durante escenas con múltiples efectos visuales.

Para ello se establecen los siguientes criterios:

\begin{itemize}
    \item Las plataformas deben distinguirse claramente del decorado.
    \item Los elementos peligrosos deben utilizar colores y formas reconocibles.
    \item Los enemigos deben conservar siluetas definidas.
    \item Los objetos recolectables deben atraer la mirada mediante brillo o contraste.
    \item Los efectos visuales no deben bloquear información importante para el jugador.
\end{itemize}

El equilibrio entre detalle artístico y claridad mecánica permitirá mantener una experiencia visual atractiva sin comprometer la jugabilidad ni la comprensión inmediata del entorno.
>>>>>>> upstream/master
