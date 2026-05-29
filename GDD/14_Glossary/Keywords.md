\subsection{Glosario de Términos}

Este apartado compila las definiciones de las palabras clave utilizadas a lo largo de este documento de diseño de juego, clasificadas para facilitar su consulta por parte de desarrolladores, artistas y diseñadores externos.

\subsubsection*{Términos Narrativos y del Lore}

\begin{itemize}
    \item \textbf{Corazón del Bosque:} Reliquia cristalina ancestral ubicada originalmente en el bosque de Eldergrove que servía como fuente de vida y equilibrio natural para el Reino de Valtheria.
    \item \textbf{La Noche de la Ceniza:} Cataclismo mágico desencadenado por la traición del Archimago Malakor, durante el cual el Corazón del Bosque fue destruido y una plaga de ceniza necrótica devastó el reino.
    \item \textbf{Eco de Elara:} Proyección espiritual de la Gran Sacerdotisa Elara, quien sacrificó su vida para evitar el colapso absoluto de Eldergrove. Actúa como guía y checkpoint para Sir Gareth.
    \item \textbf{Diamantes de Almas:} Gemas de cristalización mágica resultantes de la reacción de la ceniza con las almas puras de los ciudadanos. Se emplean como moneda económica para la purificación de Gareth.
    \item \textbf{Jardines Marchitos:} Zona introductoria del juego. Antiguos jardines reales de la corte elfa, ahora asfixiados por vegetación espinosa y patrullados por antiguos centinelas.
    \item \textbf{Mazmorras del Eco:} Entornos subterráneos bajo el castillo de Valtheria caracterizados por distorsiones temporales del Eco y la presencia de trampas mecánicas autónomas.
    \item \textbf{Torre Marchita:} Bastión del Hechicero Oscuro Lord Malakor y epicentro de la niebla corrupta que cubre el reino.
\end{itemize}

\subsubsection*{Términos Técnicos y de Programación (Unity 6)}

\begin{itemize}
    \item \textbf{Corte Vertical (Vertical Slice):} Prototipo jugable completamente funcional que muestra el acabado estético y la jugabilidad de una sección pequeña del juego final, reduciendo el Scope Creep académico.
    \item \textbf{Object Pooling:} Patrón de optimización que pre-instancia una colección de objetos (ej. flechas) en memoria para activarlos y desactivarlos dinámicamente en lugar de utilizar \texttt{Instantiate()} y \texttt{Destroy()} en cada frame.
    \item \textbf{LeanTween:} Librería de interpolación de código abierto para Unity que permite realizar movimientos de físicas, opacidades de UI y escalados mediante ecuaciones matemáticas directas en memoria.
    \item \textbf{Parallax Scrolling (Desplazamiento Parallax):} Técnica visual en la que múltiples imágenes de fondo se desplazan a diferentes velocidades relativas a la cámara, creando una ilusión de profundidad en 2D/2.5D.
    \item \textbf{FSM (Finite State Machine / Máquina de Estados Finitos):} Modelo de comportamiento lógico estructurado mediante estados discretos (Patrulla, Persecución, Ataque, Muerte) y transiciones gobernadas por condiciones espaciales u operativas.
    \item \textbf{Cinemachine:} Suite oficial de Unity para el control automatizado e inteligente del comportamiento de cámaras (seguimiento de personaje, amortiguaciones y confinado en 2D).
    \item \textbf{PPU (Pixels Per Unit / Píxeles por Unidad):} Parámetro de importación en los sprites de Unity que define cuántos píxeles de la textura equivalen a una unidad métrica de distancia física en el espacio del motor.
    \item \textbf{HUD (Heads-Up Display):} Interfaz gráfica fija que muestra información de estado directamente en la pantalla de juego (corazones de vida, contador de diamantes).
    \item \textbf{CompositeCollider2D:} Componente físico de Unity que unifica múltiples colisionadores individuales de un Tilemap en un único cuerpo compuesto de colisión, optimizando el detector físico.
    \item \textbf{IFrames (Frames de Invulnerabilidad):} Lapso de tiempo corto tras recibir daño durante el cual la matriz física del jugador ignora las colisiones hostiles, evitando muertes instantáneas por colisión múltiple.
    \item \textbf{Time-to-Kill (TTK / Tiempo de Eliminación):} Métrica de diseño que define el tiempo o número exacto de impactos requeridos para derrotar a un enemigo, permitiendo balancear el progreso del juego.
    \item \textbf{Canvas Scaler:} Componente del Canvas de Unity que ajusta y escala de forma automática el tamaño de la UI física basándose en una resolución de referencia (fijada en $1920 \times 1080$).
\end{itemize}
