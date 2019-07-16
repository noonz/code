import pygame
import random
from pygame.sprite import Sprite


class Minion(Sprite, ws_game):
    """Class for minion"""

    def __init__(self):
        super().__init__()
        self.screen = WSUP.game_screen

        # Select image and and set the rect
        # This uses rel filepath
        self.image = pygame.image.load('images/trihard.png')
        self.rect = self.image.get_rect()

        # Generate a random position for the minion
