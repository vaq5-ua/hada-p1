PREGUNTA 1
	La opción -n del comando revert se utliza para que no se haga un commit automáticamente.
PREGUNTA 2
	Deshace los cambios, en este caso permite recuperar el archivo eliminado.
PREGUNTA 3
	El git revert crea un nuevo commit con el contenido del commit especificado.
	El git reset reestablece el historial para que coincida con el estado del repositorio en el commit especificado.
PREGUNTA 4
	Git merge al ser aplicado, mantiene a salvo la historia de la rama secundaria, ya que crea un nuevo commit que une ambas ramas sin eliminarlas.
	Git rebase al ser aplicado, NO mantiene a salvo la historia de la rama secundaria, sino que “re-escribe” la historia de la rama principal integrando los commits de la rama secundaria en la rama principal, no crea un commit de unión adicional, sino que cambia el puntero (HEAD) al último commit que ubica.