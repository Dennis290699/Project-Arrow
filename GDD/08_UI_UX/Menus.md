\subsection{Menús}

El juego implementa tres interfaces de navegación principales organizadas dentro de vistas de canvas específicas, utilizando transiciones suavizadas por código para mejorar la experiencia de usuario y el acabado visual.

\subsubsection{Menú Principal}

El Menú Principal se encuentra ubicado en su propia escena y actúa como el primer punto de contacto. Cuenta con un Canvas configurado con una relación de aspecto fija y los siguientes paneles:
\begin{itemize}
    \item \textbf{Panel de Título:} Muestra el nombre \emph{Chronicles of the Cursed Knight} con tipografía estilizada y efectos de iluminación.
    \item \textbf{Panel de Opciones de Navegación:} Botones de interacción física (\texttt{Iniciar Partida}, \texttt{Salir del Juego}).
    \item \textbf{Comportamiento de Botones:} Las interacciones de los botones reproducen señales sonoras cortas (sonido de "Click" gestionado por \texttt{SceneManagement.cs}). Al presionar \texttt{Iniciar Partida}, el sistema invoca una transición de opacidad lenta y carga de forma asíncrona la escena narrativa inicial.
\end{itemize}

\subsubsection{Menú de Pausa}

Se activa en pleno juego al presionar la tecla \texttt{Esc}. El panel de pausa pausa el juego congelando la escala de tiempo física (\texttt{Time.timeScale = 0f}).
\begin{itemize}
    \item \textbf{Controles Disponibles:} Botones de \texttt{Reanudar} (desactiva el panel y devuelve \texttt{Time.timeScale = 1f}), \texttt{Reiniciar Nivel} (carga de nuevo el índice activo del escenario) y \texttt{Menú Principal}.
    \item \textbf{Transición Visual:} Se utiliza un shader de desenfoque (\emph{Blurry Screen Shader}) en el fondo y se transiciona la opacidad de la interfaz mediante \texttt{LeanTween.alphaCanvas()} sobre el \texttt{CanvasGroup} del menú.
\end{itemize}

\subsubsection{Pantalla de Derrota (Game Over)}

Se despliega de forma inmediata cuando los corazones de Sir Gareth llegan a $0$. Su aparición en pantalla sigue un flujo animado para suavizar la derrota del jugador:
\begin{itemize}
    \item \textbf{Lógica de Animación (LeanTween):} Inicialmente, el panel de derrota (\texttt{gameOverUIBG}) se sitúa fuera de los límites visibles de la pantalla, en una coordenada vertical positiva elevada (ej. $Y = 800f$).
    \item \textbf{Efecto de Caída Rebotante:} Al morir el personaje, el script ejecuta una interpolación que desplaza el panel hacia el centro físico de la pantalla ($Y = 0f$):
    \begin{verbatim}
    LeanTween.moveLocalY(gameOverUIBG, 0f, 0.8f).setEaseOutBounce();
    \end{verbatim}
    El uso de \texttt{setEaseOutBounce} en un intervalo de $0.8$ segundos genera un efecto elástico de rebote físico, atrayendo la atención del jugador sobre la interfaz de forma dinámica.
    \item \textbf{Opciones:} Botón \texttt{Reintentar} (reinicia la escena activa) y \texttt{Salir} (regresa al menú principal). Al activarse la pantalla, se reproduce una melodía sombría en bucle a través del \texttt{AudioManager}.
\end{itemize}

\subsubsection{Pantalla de Victoria}

Se activa al ingresar en el Trigger de finalización de nivel en los Portones del Castillo, una vez verificado que el jugador sigue con vida:
\begin{itemize}
    \item \textbf{Lógica de Animación (LeanTween):} Al igual que la pantalla de derrota, el panel de victoria (\texttt{victoryUIBG}) inicia oculto bajo la pantalla (ej. $Y = -800f$).
    \item \textbf{Efecto de Desplazamiento Suave:} El script desplaza verticalmente el panel hacia el centro en un lapso de $0.8$ segundos utilizando una ecuación de retroceso inicial y final:
    \begin{verbatim}
    LeanTween.moveLocalY(victoryUIBG, 0f, 0.8f).setEaseInOutBack();
    \end{verbatim}
    Esta animación genera un deslizamiento elegante que se frena suavemente en el centro del Canvas.
    \item \textbf{Datos del nivel:} Muestra dinámicamente las estadísticas almacenadas en el \texttt{GameManager} durante la partida (diamantes recolectados en el nivel y porcentaje de corazones restantes).
    \item \textbf{Navegación:} El botón \texttt{Continuar} llama a \texttt{SceneManagement} para realizar la carga asíncrona de la siguiente escena.
\end{itemize}