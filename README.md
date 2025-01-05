# WEATHER APP

## Prérequis

Avant de pouvoir exécuter ce projet, assurez-vous d'avoir les éléments suivants installés sur votre machine :

- [SDK .NET](https://dotnet.microsoft.com/download) (version 7.0 de préférence)
- [Avalonia](https://avaloniaui.net/)

### Ajouter une clé API

Après avoir cloner le repo,

- Créer un fichier .env à la racine
- Copier/coller ceci : ```API_KEY=*apikey*``` (en remplaçant *apikey* par votre clé API Openweatherapp)

## Pour lancer le projet

### Lancer avec Dotnet

Taper la commande suivante à la racine du projet :

```powershell
dotnet run
```

/!\ En cas d'erreur **NETSDK1045 (The current .NET SDK does not support targeting .NET 7.0.)**, allez dans [ce fichier](GetStartedApp.csproj) et modifier *net7.0* pour mettre la version que vous avez.

(Pour regarder votre version, tapez dotnet --version)

**En cas de problème avec le lancement du projet, contactez l'un des contributeurs : Aymeric MAREC, Noémie DUBLANC, Diane SAUTEREAU DU PART**
