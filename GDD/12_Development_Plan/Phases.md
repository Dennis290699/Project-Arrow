\subsection{Fases de Desarrollo}

\subsubsection*{Documento de Diseño como Fundamento}

El presente Game Design Document (GDD) constituye la fase documental inicial y punto de partida fundamental del proyecto \textit{Chronicles of the Cursed Knight}. En esta etapa se establece la visión creativa, los pilares de diseño, la narrativa, la estética visual y sonora, así como las mecánicas de juego que guiarán todo el proceso de desarrollo. Este documento sirve como referencia central para el equipo, definiendo el concepto, alcance y dirección artística antes de cualquier implementación técnica. Toda decisión de diseño posterior se alinea con los lineamientos aquí establecidos, asegurando coherencia entre la propuesta original y el producto final.

\subsubsection{Fase 1: Configuración y base técnica}

La primera fase contempla la creación del repositorio en GitHub, configuración de \texttt{.gitignore}, activación de Git LFS, preparación del proyecto en Unity y desarrollo de los controles base del jugador. El resultado esperado es un personaje capaz de moverse, saltar y responder correctamente a entradas.

\subsubsection{Fase 2: Integración visual y colisiones}

La segunda fase se centra en importar sprites, realizar slicing, configurar animaciones del jugador y construir escenarios mediante Tilemaps. También se implementan colisiones con \texttt{TilemapCollider2D} y \texttt{CompositeCollider2D}.

\subsubsection{Fase 3: Enemigos y sistema de daño}

La tercera fase incorpora enemigos con IA de patrulla, persecución y ataque. Se implementa el sistema de salud, daño mutuo, muerte de enemigos y retroalimentación básica.

\subsubsection{Fase 4: Recolección, HUD y cámara}

La cuarta fase incluye ítems recolectables, contador de Diamantes de Almas, HUD, cámara con Cinemachine y efecto parallax. En esta etapa la experiencia comienza a parecerse a un corte vertical jugable.

\subsubsection{Fase 5: Audio, menús y mejoras}

La quinta fase integra música, efectos de sonido, menú principal, menú de pausa y sistema de mejoras. También se conectan checkpoints con la economía interna.

\subsubsection{Fase 6: QA, balance y build}

La fase final se dedica a pruebas de calidad, resolución de errores, ajuste de dificultad, pulido visual y sonoro, y generación del ejecutable para Windows.