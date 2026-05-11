\section{Audio: Efectos de Sonido}

\subsection{Principios generales}

Los efectos de sonido deben proporcionar retroalimentacion inmediata y contribuir a la atmosfera. Cada accion importante del jugador debe tener una respuesta sonora reconocible: pasos, salto, aterrizaje, golpe de espada, impacto contra enemigo, recoleccion y dano recibido.

\subsection{Efectos principales}

\textbf{Pasos.} Deben variar ligeramente en tono mediante codigo para evitar repeticion perceptible. La superficie del nivel puede modificar el timbre en fases posteriores.

\textbf{Espada.} Los ataques deben incluir sonidos metalicos, desplazamiento de aire y un impacto diferenciado cuando el golpe conecta con un enemigo.

\textbf{Recoleccion.} Los Diamantes de Almas deben emitir un sonido agudo y breve, similar a una campana cristalina, para reforzar la satisfaccion de obtencion.

\textbf{Dano.} El dano recibido por el jugador debe tener un sonido claro pero no excesivamente intrusivo. Los enemigos pueden utilizar variaciones segun tipo o tamano.

\subsection{Implementacion tecnica}

Los objetos clave deben utilizar componentes \texttt{AudioSource}. La gestion de volumen, mezcla y reproduccion puede centralizarse mediante un administrador de audio, permitiendo separar musica, efectos y posibles voces.

