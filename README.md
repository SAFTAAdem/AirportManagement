#✈️ AirportManagement - Système de Gestion Aéroportuaire

Ce projet est une application console .NET robuste conçue pour gérer les opérations quotidiennes d'un aéroport (vols, passagers, avions). Il a été développé dans un cadre académique pour mettre en pratique les concepts avancés du langage **C#** et de l'accès aux données avec **Entity Framework Core**.

## 🚀 Fonctionnalités Clés

* **Gestion des Vols & Passagers :** CRUD complet pour les entités de l'aéroport.
* **Services de Données :** Utilisation intensive de **LINQ** pour le filtrage et la recherche complexe.
* **Architecture Propre :** Séparation nette entre le domaine (Domain), la logique métier (Services) et l'infrastructure.
* **Persistance des données :** Intégration de SQL Server via Entity Framework.

## 🛠️ Concepts Techniques Maîtrisés

Ce projet démontre l'application des concepts suivants :
* **LINQ (Language Integrated Query) :** Requêtes optimisées pour extraire des statistiques sur les vols.
* **Delegates & Lambdas :** Utilisation de prédicats pour rendre les méthodes de recherche génériques.
* **Méthodes d'extension :** Amélioration des types existants pour des manipulations de données plus fluides.
* **Gestion de la Sécurité :** Implémentation des **User Secrets** pour protéger les chaînes de connexion à la base de données.

## 🏗️ Architecture du Projet

```text
AirportManagement/
├── AM.Domain/         # Classes de base (Flight, Passenger, Plane, etc.)
├── AM.Services/       # Logique métier et interfaces
├── AM.Infrastructure/ # Configuration EF Core et Contexte de base de données
└── AM.UI.Console/     # Interface utilisateur et point d'entrée
