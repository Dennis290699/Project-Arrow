\subsection{Música}

\subsubsection*{Dirección musical}

La dirección musical del proyecto debe construir una identidad sonora coherente con el universo fantástico y melancólico de \textit{Sir. Garet}, reforzando tanto la exploración como la narrativa emocional del juego. Debido a que se trata de un videojuego de plataformas 2D con estética \textit{pixel art}, la banda sonora debe combinar elementos orquestales suaves con sintetizadores ambientales y sonidos inspirados en composiciones retro, manteniendo un equilibrio entre nostalgia y fantasía medieval.

Durante las secciones de exploración, la música debe presentar tempos moderados o lentos, utilizando instrumentos como flautas, violines suaves, arpas y pads ambientales que transmitan sensación de soledad, misterio y descubrimiento. Las composiciones deben evitar saturar al jugador, permitiendo que los efectos de sonido del entorno y las acciones del personaje mantengan protagonismo dentro de la experiencia jugable.

En las secuencias de combate o enfrentamientos importantes, especialmente contra jefes, la música debe evolucionar hacia arreglos más intensos mediante el uso de percusión marcada, cuerdas tensas, coros ambientales y motivos melódicos repetitivos que incrementen la sensación de peligro y urgencia. Cada jefe puede poseer pequeñas variaciones temáticas derivadas de la melodía principal del juego para mantener cohesión sonora entre las diferentes secciones del prototipo.

Adicionalmente, se recomienda el uso de leitmotivs asociados a personajes o lugares importantes. El motivo principal de Sir. Garet debe transmitir valentía y determinación, mientras que el motivo relacionado con Elara debe mantener un carácter etéreo y emocional, utilizando tonalidades menores y melodías suaves que evoquen recuerdos y esperanza.

\subsubsection*{Formato e implementación}

Las pistas musicales pueden almacenarse utilizando formatos comprimidos como \texttt{.ogg} o \texttt{.mp3}, priorizando \texttt{.ogg} debido a su mejor relación entre calidad y tamaño de archivo para videojuegos independientes. Los efectos de sonido cortos pueden utilizar formatos como \texttt{.wav} cuando se requiera menor latencia durante la reproducción.

Dentro de Unity, la administración del sistema de audio debe realizarse mediante un controlador global, como un objeto \texttt{GameManager} o un sistema dedicado denominado \texttt{AudioManager}. Este sistema debe encargarse de:

\begin{itemize}
    \item Gestionar la reproducción de música ambiental y efectos de sonido.
    \item Controlar transiciones suaves entre pistas mediante efectos de \textit{fade in} y \textit{fade out}.
    \item Ajustar niveles de volumen independientes para música, efectos y sonidos ambientales.
    \item Permitir la reutilización de pistas mediante reproducción en bucle (\textit{loop}) durante exploración o combate sostenido.
    \item Facilitar futuras expansiones del proyecto mediante un sistema modular de audio.
\end{itemize}

Para mejorar la inmersión, ciertas capas musicales pueden activarse dinámicamente dependiendo del estado del jugador, como niveles bajos de salud, proximidad a enemigos o descubrimiento de áreas ocultas. Este enfoque permite generar una experiencia más reactiva e interactiva.

\subsubsection*{Uso narrativo}

La música debe desempeñar un papel narrativo importante dentro del prototipo, ayudando a comunicar emociones, ambientación y progresión del viaje de Sir. Garet. Cada zona del juego debe poseer una identidad sonora diferenciada que permita al jugador reconocer emocionalmente el entorno incluso sin necesidad de elementos visuales.

Los \textit{Jardines Marchitos} deben transmitir abandono, decadencia y nostalgia mediante melodías lentas, reverberaciones suaves y sonidos ambientales relacionados con viento o naturaleza deteriorada. En contraste, las \textit{Mazmorras del Eco} deben enfatizar sensaciones de encierro, incertidumbre y peligro utilizando notas graves, ecos prolongados y silencios parciales que generen tensión psicológica.

La \textit{Torre del Hechicero} debe representar el clímax narrativo del prototipo. Su música puede incorporar percusión intensa, coros oscuros y armonías disonantes que refuercen la confrontación final y el peligro inminente.

El motivo musical de Elara puede aparecer en momentos clave como puntos de control, escenas narrativas, descubrimientos importantes o secuencias relacionadas con recuerdos del pasado. La repetición progresiva de este motivo permitirá fortalecer la conexión emocional entre el jugador y la narrativa del juego.

Finalmente, el sistema musical debe estar diseñado considerando futuras expansiones del proyecto, permitiendo añadir nuevos niveles, enemigos y zonas sin romper la coherencia sonora establecida en el prototipo inicial.

\subsubsection*{Diseño Detallado de la Banda Sonora (Prototipo)}

La siguiente tabla resume los temas musicales planificados para el prototipo, su instrumentación y la atmósfera que buscan establecer en el jugador:

\begin{center}
\begin{tabular}{|p{3cm}|p{4.5cm}|p{6.7cm}|}
\hline
\textbf{Tema Musical} & \textbf{Instrumentación Principal} & \textbf{Atmósfera y Propósito Narrativo} \\
\hline
Menú Principal & Chelo solo, arpa y pad de sintetizador. & Nostalgia y misterio; introduce el declive del reino de Valtheria. \\
\hline
Jardines Marchitos & Flauta traversa, guitarra acústica y violín suave. & Melancolía y exploración solitaria; refleja la naturaleza muerta y la soledad del héroe. \\
\hline
Mazmorras del Eco & Pads de bajo profundo, piano disonante y platillos metálicos lejanos. & Tensión, claustrofobia e incertidumbre; el sonido de eco resalta el peligro del subsuelo. \\
\hline
Torre Marchita & Órgano de tubos, percusiones orquestales y coros sintéticos. & Clímax, urgencia y confrontación épica contra el Hechicero Lord Malakor. \\
\hline
Encuentros de Combate & Cuerdas en staccato, timbales pesados y vientos de madera rápidos. & Adrenalina y peligro inmediato; se activa al iniciar combates contra grupos de enemigos. \\
\hline
Eco de Elara (Checkpoints) & Caja de música, arpa celestial y soprano lírica etérea. & Paz, seguridad y esperanza temporal; reconforta al jugador en los puntos de descanso. \\
\hline
\end{tabular}
\end{center}
