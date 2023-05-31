Feature: AuthorFeatures

Use cases relatifs aux auteurs

Scenario: Ajouter un nouvelle auteur
 Given Un auteur existe
 And son nom est John
 And son prenom est Doe
 And sa date de naissance est 01/01/1970
 When je veux ajouter un auteur
 Then l'auteur est ajouté
 
 Scenario Outline: Ajouter un nouvelle auteur 2
	 Given Un auteur existe
	 And son nom est <nom>
	 And son prenom est <prénom>
	 And sa date de naissance est <date>
	 When je veux ajouter un auteur
	 Then l'auteur est ajouté
 Examples: 
| nom | prénom | date |
| John | Doe | 01/01/1970 |
| Jane | Doe | 01/01/1970 |
| John | Smith | 01/01/1970 |