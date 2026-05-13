\subsection{Diálogos y expresiones visuales}

\subsubsection*{Alcance inicial}

Debido al estilo \textit{pixel art} y al enfoque retro del proyecto, el prototipo no utilizará actuación de voz ni diálogos hablados. En su lugar, la narrativa y las interacciones entre personajes se representarán mediante cuadros de texto en pantalla, expresiones visuales y pequeñas reacciones animadas inspiradas en videojuegos clásicos, especialmente aquellos que transmitían personalidad sin necesidad de voces completas.

Este enfoque permite mantener coherencia con la estética del juego, reducir complejidad técnica y conservar un estilo nostálgico que favorece la inmersión dentro del universo fantástico de \textit{Chronicles of the Cursed Knight}.

Los diálogos deben presentarse de forma breve y clara, evitando bloques extensos de texto que interrumpan el ritmo de la exploración y las plataformas. Las conversaciones importantes pueden mostrarse mediante ventanas con retratos pixelados, expresiones faciales simples y animaciones mínimas que refuercen las emociones de los personajes.

\subsubsection*{Expresiones y comunicación no verbal}

Para compensar la ausencia de voces, los personajes deben comunicar emociones y personalidad mediante recursos visuales y sonoros sencillos. Entre los elementos recomendados se incluyen:

\begin{itemize}
    \item Pequeñas animaciones de reacción.
    \item Cambios de postura corporal.
    \item Expresiones faciales simplificadas.
    \item Iconos o símbolos sobre los personajes.
    \item Efectos sonoros cortos de sorpresa, alerta o interacción.
\end{itemize}

Siguiendo la inspiración de videojuegos clásicos sin doblaje completo, los personajes pueden emitir sonidos breves y estilizados durante conversaciones, como murmullos, exclamaciones suaves o pequeños efectos vocales abstractos. Estos sonidos no representan palabras reales, sino recursos expresivos que aportan personalidad sin requerir actuación de voz profesional.

\subsubsection*{Narrativa mediante texto}

Los cuadros de diálogo deben utilizar una tipografía legible acorde al estilo \textit{pixel art}, manteniendo contraste adecuado con el fondo para facilitar lectura durante la partida.

Los mensajes narrativos pueden emplearse para:

\begin{itemize}
    \item Introducir objetivos del jugador.
    \item Explicar eventos importantes.
    \item Describir elementos del entorno.
    \item Presentar interacciones entre personajes.
    \item Mostrar pensamientos o recuerdos relacionados con la historia.
\end{itemize}

El sistema de diálogos debe permitir avanzar manualmente el texto para que el jugador controle el ritmo de lectura. En momentos importantes, pueden utilizarse pausas, animaciones o cambios de expresión para generar mayor impacto emocional.

\subsubsection*{Implementación técnica}

Dentro de Unity, los diálogos pueden implementarse mediante interfaces de usuario (\texttt{UI Canvas}) acompañadas de sistemas de texto dinámico utilizando componentes como \texttt{TextMeshPro}. Cada cuadro de diálogo puede incluir:

\begin{itemize}
    \item Nombre del personaje.
    \item Texto progresivo con efecto de escritura.
    \item Sonidos cortos asociados a la aparición de caracteres.
\end{itemize}

Los efectos sonoros utilizados durante conversaciones deben ser ligeros y repetitivos, simulando expresiones vocales simples sin generar fatiga auditiva. Este enfoque permite mantener bajo el tamaño del proyecto y facilita futuras expansiones narrativas sin depender de grabaciones de voz complejas.

Finalmente, la ausencia de doblaje completo favorece la localización futura del videojuego, ya que únicamente sería necesario traducir los textos mostrados en pantalla sin reemplazar archivos de audio adicionales.
