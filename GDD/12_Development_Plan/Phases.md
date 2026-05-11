\section{Plan de Desarrollo: Fases}

\subsection{Fase 1: Configuracion y base tecnica}

La primera fase contempla la creacion del repositorio en GitHub, configuracion de \texttt{.gitignore}, activacion de Git LFS, preparacion del proyecto en Unity y desarrollo de los controles base del jugador. El resultado esperado es un personaje capaz de moverse, saltar y responder correctamente a entradas.

\subsection{Fase 2: Integracion visual y colisiones}

La segunda fase se centra en importar sprites, realizar slicing, configurar animaciones del jugador y construir escenarios mediante Tilemaps. Tambien se implementan colisiones con \texttt{TilemapCollider2D} y \texttt{CompositeCollider2D}.

\subsection{Fase 3: Enemigos y sistema de dano}

La tercera fase incorpora enemigos con IA de patrulla, persecucion y ataque. Se implementa el sistema de salud, dano mutuo, muerte de enemigos y retroalimentacion basica.

\subsection{Fase 4: Recoleccion, HUD y camara}

La cuarta fase incluye items recolectables, contador de Diamantes de Almas, HUD, camara con Cinemachine y efecto parallax. En esta etapa la experiencia comienza a parecerse a un corte vertical jugable.

\subsection{Fase 5: Audio, menus y mejoras}

La quinta fase integra musica, efectos de sonido, menu principal, menu de pausa y sistema de mejoras. Tambien se conectan checkpoints con la economia interna.

\subsection{Fase 6: QA, balance y build}

La fase final se dedica a pruebas de calidad, resolucion de errores, ajuste de dificultad, pulido visual y sonoro, y generacion del ejecutable para Windows.

