Feature: ScoreSetTennisSpecFlowFeature

    Scenario: Jouer gagne premier set
        Given Scone initial du set pour Joueur 1 est 4 et Joueur 2 est 5
        And dans un set le score du jeu initial du joueur 1 est de 15
        And dans un set le score du jeu initial du joueur 2 est de 40
        When dans un set le joueur 2 marque un point
        Then le set a gagné le joueur 2

    Scenario: Set arrive en tie break
        Given Scone initial du set pour Joueur 2 est 6 et Joueur 1 est 5
        And dans un set le score du jeu initial du joueur 1 est de 15
        And dans un set le score du jeu initial du joueur 2 est de 40
        When dans un set le joueur 2 marque un point
        Then le set est en tie break
        And le score de jouer 1 en tie break est 0
        And le score de jouer 2 en tie break est 0
        
    Scenario: Set gagné en tie break 
        Given Scone initial du set pour Joueur 2 est 6 et Joueur 1 est 5
        And dans un set le score du jeu initial du joueur 1 est de 15
        And dans un set le score du jeu initial du joueur 2 est de 40
        When dans un set le joueur 2 marque 8 points
        Then le set a gagné le joueur 2