# Présentation du Projet

REL – Gestion de Demandes

## Contexte
L'application de gestion de cantine centralise la gestion des utilisateurs, des tables et, dans certaines versions, des menus ou des présences. Elle facilite l'organisation d'une cantine scolaire ou associative en offrant une vue d'ensemble des ressources.

## Objectifs
- Gérer efficacement les utilisateurs et les tables
- Permettre aux administrateurs d'ajouter, modifier ou supprimer des données
- Sécuriser l'accès aux données selon les rôles (administrateur ou utilisateur)
- Proposer une interface intuitive avec un retour visuel sur les opérations

## Spécifications Fonctionnelles
### Gestion des Utilisateurs
- Inscription et connexion
- Rôle utilisateur et administrateur
- Possibilité de modifier ses informations personnelles

### Gestion des Tables
- Ajout, modification et suppression des tables disponibles
- Affichage dans un tableau `DataGridView`

### Gestion des Présences (facultatif)
- Enregistrement de la présence des utilisateurs à un repas
- Affichage d'un historique

### Interface Utilisateur
- Formulaires clairs
- Validation avec `ErrorProvider`

## Spécifications Techniques

### Architecture
- Couche d'accès aux données (`BDD`)
- Couche métier (`Utilisateur`, `Tables`, etc.)
- Couche interface (`FormMain`, `Connexion`, etc.)

### Sécurité
- Authentification par mot de passe
- Droits selon les rôles
- Validation des champs et `ErrorProvider`
- Prévention des injections SQL

## Structure de la base de données
Le fichier [`le_cantine.sql`](../le_cantine.sql) contient le script de création de la base de données `le_cantine`. Les tables principales sont :

- `utilisateur` : stocke les utilisateurs et leurs rôles
- `tables` : gère les tables disponibles dans la cantine
- `commande` et `contenir` : gèrent les commandes et les produits associés
- `reservation` : enregistre les réservations des tables
- `produit` : répertorie les produits disponibles

Pour installer la base de données, importez ce script dans votre serveur MySQL.
