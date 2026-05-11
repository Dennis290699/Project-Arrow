\section{Gameplay: Mecanicas}

\subsection{Movimiento fisico}

El movimiento del personaje se controla mediante la manipulacion directa de la velocidad del componente \texttt{Rigidbody2D}. Esta decision tecnica busca evitar inercias indeseadas y ofrecer una respuesta inmediata al jugador. La aceleracion visual puede ser reforzada mediante animaciones, pero la lectura mecanica debe mantenerse clara y predecible.

\subsection{Sistema de salto}

El salto se implementa mediante una verificacion precisa del suelo utilizando \texttt{Physics2D.OverlapCircle} en un punto ubicado a los pies del personaje. Esta deteccion permite determinar si el jugador esta en contacto con una superficie valida antes de autorizar un nuevo salto.

Para mejorar la sensacion de peso, el descenso incorpora un multiplicador de caida, conocido como \emph{Fall Multiplier}. Este ajuste incrementa la gravedad efectiva cuando el personaje comienza a caer, evitando saltos excesivamente livianos y proporcionando una respuesta mas satisfactoria al aterrizaje.

\subsection{Combate cuerpo a cuerpo para enemigos}

El ataque principal se realiza con espada. El sistema utiliza \emph{triggers} de colision asociados a ventanas especificas de la animacion de ataque. De este modo, el dano no ocurre durante toda la animacion, sino en el intervalo donde la espada representa visualmente un impacto valido.

Este enfoque favorece la coherencia entre animacion, retroalimentacion y resultado mecanico. Ademas, permite ajustar el balance mediante parametros como daño base, duracion de la ventana activa, tiempo de recuperacion y direccion del golpe.

\subsection{Combate a distancia personaje principal}

El ataque secundario consiste en el lanzamiento de flechas magicas o proyectiles equivalentes. La implementacion se basa en la instanciacion de prefabs con una velocidad inicial asignada.

\subsection{Economia interna}

Los enemigos derrotados y ciertas areas secretas otorgan \textbf{Diamantes de Almas}. Estos objetos actuan como moneda interna y pueden intercambiarse en estatuas de guardado o puntos de mejora. Las mejoras principales contempladas son aumento de salud maxima, incremento del dano base y posibles extensiones futuras de energia magica.

\subsection{Retroalimentacion al jugador}

Cada accion relevante debe comunicar su resultado mediante una combinacion de animacion, sonido, efectos visuales e interfaz. Los golpes deben producir particulas y sacudida leve de camara; la recoleccion debe emitir destellos y sonido distintivo; el dano recibido debe reflejarse en la barra de vida, animacion de impacto e invulnerabilidad temporal.

