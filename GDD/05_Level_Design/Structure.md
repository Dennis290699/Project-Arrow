\subsection{Estructura}

\subsubsection*{Organización general}

La estructura del videojuego se organiza en zonas temáticas conectadas de forma lineal y progresiva. Cada sección introduce variaciones ambientales, nuevos obstáculos y un incremento de dificultad coherente con la progresión del personaje. Para el alcance del prototipo actual, los esfuerzos de desarrollo e integración se concentran en la primera área jugable completa.

\subsubsection*{Escala y Sistema de Cuadrícula (Grid System)}

Para garantizar un diseño de niveles coherente, un ritmo de juego justo y evitar problemas de colisiones o bloqueos del jugador (\emph{softlocks}), todo el entorno de los niveles se rige bajo una estricta normativa matemática de espacios:
\begin{itemize}
    \item \textbf{Grid de Unity:} El mapeado se construye sobre un componente \texttt{Grid} predeterminado con celdas de $1 \times 1$ unidades de Unity.
    \item \textbf{Proporción de Assets (Pixels Per Unit - PPU):} Tanto los sprites del entorno (\textit{Tilesets} de suelo, plataformas y ruinas) como los de los personajes se configuran en el motor con un PPU estandarizado. Esto asegura que encajen perfectamente en la cuadrícula y que las colisiones mediante \texttt{TilemapCollider2D} y \texttt{CompositeCollider2D} se calculen de forma limpia y predecible.
\end{itemize}

\subsubsection*{Métricas Espaciales de Diseño (Level Design Metrics)}

Las capacidades físicas programadas en el script del jugador (\texttt{PlayerController.cs}) definen las reglas absolutas para la construcción topográfica de los escenarios:
\begin{itemize}
    \item \textbf{Salto Vertical Máximo (Max Vertical Jump):} $4.5$ unidades de Unity.
    \begin{itemize}
        \item \emph{Regla de Diseño:} Ninguna plataforma crítica necesaria para avanzar en el nivel puede situarse a una altura superior a $4.0$ unidades respecto al suelo de despegue. Las plataformas colocadas a $4.5$ unidades requieren una ejecución de salto perfecta (o el uso del doble salto) y se reservan exclusivamente para zonas de botín y secretos.
    \end{itemize}
    \item \textbf{Salto Horizontal Máximo (Max Horizontal Jump):} $6.0$ unidades de Unity (asumiendo velocidad máxima y salto en el borde).
    \begin{itemize}
        \item \emph{Regla de Diseño:} La distancia máxima permitida para fosos con pinchos, abismos o caídas mortales transitables no debe superar las $5.5$ unidades de ancho. Distancias mayores requieren colocar una plataforma flotante intermedia obligatoria.
    \end{itemize}
    \item \textbf{Gálibo y Diseño de Pasillos (Clearance Height):} El volumen de colisión (\texttt{BoxCollider2D}) de Sir Gareth y de los enemigos pesados (Esqueletos) ocupa entre $1.5$ y $2.0$ unidades de altura física.
    \begin{itemize}
        \item \emph{Regla de Diseño:} Los pasillos cerrados, túneles bajo tierra o pasajes con techo deben poseer una altura libre mínima de $3.0$ unidades. Esto garantiza que el jugador tenga espacio suficiente para realizar pequeños saltos, evadir flechas y ejecutar un Dash sin colisionar bruscamente la cabeza contra el techo.
    \end{itemize}
\end{itemize}

\subsubsection*{Zonas de los Jardines Marchitos}

Los \textit{Jardines Marchitos} actúan como el nivel introductorio del prototipo:
\begin{itemize}
    \item \textbf{Estructura:} Espacios abiertos al aire libre combinados con pequeñas ruinas de piedra. En los primeros minutos, el jugador aprende a moverse horizontalmente y a saltar pequeños desniveles de $2$ unidades de alto sin enemigos.
    \item \textbf{Distribución de Amenazas:} Introduce de forma aislada al \textit{Esqueleto Reanimado} en plataformas largas, al \textit{Arquero Corrompido} en elevaciones para retar el salto y al \textit{Ninja de la Sombra} en zonas angostas.
    \item \textbf{Objetivo Jugable:} Atravesar el nivel esquivando pinchos y sierras móviles, activar el Eco de Elara (checkpoint) para mejorar estadísticas y llegar a los portones del castillo.
\end{itemize}

\subsubsection*{Construcción técnica del entorno}

Los escenarios se construyen utilizando paletas de baldosas (\textit{Tilemaps}) en Unity, divididas en capas lógicas:
\begin{itemize}
    \item \textbf{Tilemap Ground:} Terreno sólido con el componente \texttt{TilemapCollider2D} y \texttt{CompositeCollider2D} configurado en modo \texttt{Polygonal} para unificar las colisiones y optimizar el rendimiento.
    \item \textbf{Tilemap Background:} Elementos visuales del fondo sin colisión (capa parallax intermedia).
    \item \textbf{Tilemap Decoration:} Detalles como antorchas, estatuas y vegetación marchita sin colisiones.
\end{itemize}