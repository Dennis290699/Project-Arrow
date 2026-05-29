\subsection{Construcción del Mundo}

El mundo de \emph{Chronicles of the Cursed Knight} se sitúa en las ruinas góticas del reino de \textbf{Valtheria} y el bosque marchito de \textbf{Eldergrove}. Tras la catástrofe de la Noche de la Ceniza, la geografía del reino refleja una naturaleza corrompida por fuerzas oscuras y la decadencia de una civilización medieval que una vez fue gloriosa.

\subsubsection*{Estructura de capas Parallax 2.5D}

Para lograr la ambientación gótica e inmersiva característica del proyecto sin abandonar la jugabilidad bidimensional, los escenarios se construyen bajo una estructura de cinco capas de desplazamiento diferencial (\emph{Parallax Scrolling}) reguladas por la cámara:

\begin{itemize}
    \item \textbf{Capa 1: Fondo Lejano (Far Background - Velocidad Parallax 0.05):} Contiene elementos celestes como el cielo gótico nocturno, nubes bajas en movimiento lento, neblina volumétrica y una luna llena pálida que actúa como fuente de luz principal del escenario.
    \item \textbf{Capa 2: Plano Medio Lejano (Mid-Far Background - Velocidad Parallax 0.25):} Muestra las siluetas lejanas del imponente castillo en ruinas de Valtheria, montañas escarpadas y la Torre del Hechicero recortándose contra el cielo.
    \item \textbf{Capa 3: Plano Medio Cercano (Mid-Close Background - Velocidad Parallax 0.60):} Árboles secos y retorcidos de Eldergrove, rejas de hierro oxidadas, estatuas rotas de antiguos caballeros y pilares góticos erosionados. Esta capa provee el contexto inmediato de abandono.
    \item \textbf{Capa 4: Plano Jugable (Playable Plane - Velocidad Parallax 1.0):} El entorno con colisiones activas. Contiene los Tilemaps de suelo, paredes, plataformas suspendidas, cofres, gemas, pinchos, sierras móviles y todos los personajes del juego.
    \item \textbf{Capa 5: Primer Plano Oclusivo (Foreground Occlusion - Velocidad Parallax 1.30):} Ramas de árboles oscuras, hojas secas y enredaderas desenfocadas colocadas en el borde inmediato de la pantalla. Estos elementos se desplazan más rápido que el jugador, ocluyendo la cámara temporalmente para incrementar la sensación de profundidad espacial y confinamiento.
\end{itemize}

\subsubsection*{Ambientación de los Jardines Marchitos}

Los \textit{Jardines Marchitos} son el entorno principal del prototipo. Corresponden a los antiguos jardines reales de la corte de Valtheria, ahora marchitos debido al avance de la corrupción.
\begin{itemize}
    \item \textbf{Dirección Visual:} Tonos verdes apagados, marrones otoñales y grises de piedra erosionada. Se añaden pequeños flujos de partículas que simulan hojas secas cayendo.
    \item \textbf{Iluminación:} Contraste entre la luz fría de la luna (luz ambiental azulada) y los destellos celestes de los cristales mágicos y el Eco de Elara.
\end{itemize}

\subsubsection*{Zonas subterráneas y Mazmorras}

Diseñadas para la progresión narrativa y espacial del juego, representan espacios claustrofóbicos y oscuros.
\begin{itemize}
    \item \textbf{Dirección Visual:} Predominancia de grises oscuros, azules fríos y púrpuras. Las plataformas son más estrechas y los abismos son más frecuentes.
    \item \textbf{Elementos del entorno:} Restos de celdas medievales, cadenas colgantes, y sistemas de trampas activos (como las sierras mecánicas circulares).
\end{itemize}

\subsubsection*{Narrativa ambiental}

El estado del mundo se comunica mediante el entorno gótico sin depender de diálogos constantes. La vegetación muerta, los puentes colgantes rotos, las estatuas derrumbadas de la Orden de los Guardianes y los restos de campamentos antiguos informan al jugador sobre la magnitud de la catástrofe que ocurrió en Valtheria y la gravedad del pecado de Sir Gareth.