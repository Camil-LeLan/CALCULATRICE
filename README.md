# Calculatrice WPF en C#

Application de calculatrice développée en **C# avec WPF (Windows Presentation Foundation)**, proposant une interface moderne et des fonctionnalités de calcul arithmétique et trigonométrique.

![C#](https://img.shields.io/badge/C%23-512BD4?style=flat-square&logo=dotnet&logoColor=white)
![WPF](https://img.shields.io/badge/WPF-Desktop-0078D4?style=flat-square)
![.NET](https://img.shields.io/badge/.NET-512BD4?style=flat-square&logo=dotnet&logoColor=white)
![Windows](https://img.shields.io/badge/Windows-0078D4?style=flat-square)

---

## Présentation

Ce projet consiste à développer une calculatrice de bureau sous Windows en utilisant le langage **C#** et le framework **WPF**.

L'objectif est de mettre en pratique les principes fondamentaux de la programmation orientée objet, de la programmation événementielle et de la conception d'interfaces graphiques en XAML.

L'application dispose d'une interface sombre, de boutons arrondis et d'un système de calcul permettant de réaliser des opérations mathématiques classiques ainsi que des fonctions trigonométriques.

## Fonctionnalités

### Opérations arithmétiques

| Fonction | Symbole | Exemple |
|---|---|---|
| Addition | + | 15 + 5 = 20 |
| Soustraction | − | 15 − 5 = 10 |
| Multiplication | × | 5 × 4 = 20 |
| Division | ÷ | 20 ÷ 4 = 5 |

### Fonctions trigonométriques

La calculatrice propose trois fonctions scientifiques :

| Fonction | Méthode C# | Exemple |
|---|---|---|
| Sinus | `Math.Sin()` | sin(30°) = 0,5 |
| Cosinus | `Math.Cos()` | cos(60°) = 0,5 |
| Tangente | `Math.Tan()` | tan(45°) = 1 |

Les calculs trigonométriques sont effectués en degrés, avec une conversion automatique en radians.

### Fonctionnalités complémentaires

- Saisie des nombres de 0 à 9.
- Affichage des résultats en temps réel après validation.
- Réinitialisation avec le bouton `C`.
- Gestion de la division par zéro.
- Vérification des entrées pour les fonctions trigonométriques.
- Gestion des tangentes non définies.
- Arrondi des résultats trigonométriques à 10 décimales.

## Interface graphique

L'interface utilisateur a été réalisée entièrement en XAML.

Elle repose sur un thème sombre avec des éléments visuels minimalistes.

| Élément | Couleur |
|---|---|
| Arrière-plan | `#0A0A0A` |
| Conteneur principal | `#151515` |
| Boutons numériques | `#252525` |
| Boutons d'opérations | `#D99B45` |
| Bouton de réinitialisation | `#A5A5A5` |
| Texte principal | `#FFFFFF` |

Les boutons utilisent des styles personnalisés avec des effets visuels au survol et lors du clic.

## Technologies utilisées

- **C#** : développement de la logique de calcul.
- **XAML** : conception et personnalisation de l'interface.
- **WPF** : création de l'application Windows.
- **.NET** : plateforme de développement.
- **Visual Studio** : environnement de développement.
- **Git / GitHub** : versionnement et gestion du projet.

## Architecture du projet

Le projet repose principalement sur deux fichiers.

### MainWindow.xaml

Définit les éléments graphiques de l'application :

- Structure de la fenêtre.
- Affichage numérique.
- Positionnement des boutons.
- Couleurs et styles.
- Association des boutons aux événements.

### MainWindow.xaml.cs

Contient la logique de fonctionnement :

- Gestion des événements `Click`.
- Récupération des valeurs numériques.
- Exécution des opérations mathématiques.
- Conversion des degrés en radians.
- Affichage des résultats.
- Gestion des erreurs.

### Variables principales

| Variable | Type | Description |

| `NB1` | double | Premier nombre |

| `NB2` | double | Deuxième nombre |

| `Oper` | char | Opérateur sélectionné |

| `TB_Display` | TextBox | Zone d'affichage |

## Fonctionnement

### Calcul arithmétique

Lorsqu'un utilisateur sélectionne une opération, le premier nombre est enregistré dans la variable `NB1`.

L'opérateur est ensuite mémorisé dans `Oper`.

Après la saisie du second nombre, le bouton `=` déclenche la méthode `Calcul()`.

Cette méthode utilise une instruction `switch` pour déterminer l'opération à effectuer.

```csharp
switch (operation)
{
    case '+':
        Resultat = NB1 + NB2;
        break;

    case '-':
        Resultat = NB1 - NB2;
        break;

    case '*':
        Resultat = NB1 * NB2;
        break;

    case '/':
        Resultat = NB1 / NB2;
        break;
}
```

La division par zéro est vérifiée avant son exécution.

### Calcul trigonométrique

Les méthodes trigonométriques de C# utilisent des angles exprimés en radians.

L'application effectue donc une conversion :

```csharp
double radians = nombre * Math.PI / 180;
```

Le calcul est ensuite réalisé avec la méthode correspondante :

```csharp
double resultat = Math.Sin(radians);
```

Le résultat est arrondi avant d'être affiché.

## Installation

### Prérequis

- Windows 10 ou 11.
- Visual Studio avec la charge de travail « Développement .NET Desktop ».
- SDK .NET compatible avec la version du projet.

### Exécution

1. Cloner le dépôt GitHub :

```bash
git clone https://github.com/UTILISATEUR/DEPOT.git
```

2. Ouvrir le dossier du projet dans Visual Studio.

3. Ouvrir le fichier de solution `.sln` ou le fichier `.csproj`.

4. Restaurer les dépendances si nécessaire.

5. Compiler et exécuter l'application avec `F5`.

*Remplacer l'URL de clonage par celle du dépôt réel.*

## Limites actuelles

- Les fonctions trigonométriques fonctionnent uniquement en degrés.
- La saisie des nombres décimaux ne dispose pas encore d'un bouton dédié.
- L'application ne propose pas d'historique des calculs.
- Les opérations sont réalisées de manière séquentielle, sans gestion des expressions complexes.

## Améliorations envisagées

- [ ] Ajouter un bouton pour les nombres décimaux.
- [ ] Ajouter les fonctions racine carrée et puissance.
- [ ] Intégrer un historique des calculs.
- [ ] Ajouter un mode radians/degrés.
- [ ] Permettre la saisie au clavier.
- [ ] Am
