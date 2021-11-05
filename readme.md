## Compiler le projet 

Exécuter la commande `dotnet publish -c Release -r win10-x64` à la racine du projet   

Le .exe sera généré dans le dossier `MasterMind\MasterMind\bin\Release`

## Lancer l'application 

Pour lancer le MasterMind, il suffit de lancer l'exécutable MasterMind.exe dans l'invite de commande.  

Il existe plusieurs paramètres possibles ;  
- `--help` : Affiche l'aide
- `--round` ou `-r` : Permet de définir un nombre de round pour trouver le secret (par défaut pas de round)
- `--length` ou `-l` : Permet de définir la taille du secret (par défaut 4)


## A améliorer: 
- Ajouter la possibilité d'avoir plusieurs joueurs. 