import pygame
import random
from pygame.sprite import Sprite


class Minion(Sprite, ws_game):
    """Class for TriHard's"""

    def __init__(self):
        super().__init__()
        self.screen = WSUP.game_screen

        # Select TriHard image and and set the rect
        self.image = pygame.image.load('images/trihard.png')
        self.rect = self.image.get_rect()

        # Generate a random position for the minion
