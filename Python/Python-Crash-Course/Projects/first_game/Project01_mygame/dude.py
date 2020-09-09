import pygame


class Dude:
    """A class to manage the dude"""

    def __init__(self, ws_game):
        """initialize the dude and set his positions"""
        self.screen = ws_game.screen
        self.settings = ws_game.settings
        self.screen_rect = ws_game.screen.get_rect()

        self.image = pygame.image.load('images/dude00.png')
        self.rect = self.image.get_rect()

        self.rect.center = self.screen_rect.center

        self.x = float(self.rect.x)
        self.y = float(self.rect.y)

        self.moving_right = False
        self.moving_left = False
        self.moving_down = False
        self.moving_up = False

    def update(self):
        if self.moving_right and self.rect.right < self.screen_rect.right:
            self.x += self.settings.dude_speed
            self.image = pygame.image.load('images/dude01.png')
        if self.moving_left and self.rect.left > self.screen_rect.left:
            self.x -= self.settings.dude_speed
            self.image = pygame.image.load('images/dude00.png')
        if self.moving_down and self.rect.bottom < self.screen_rect.bottom:
            self.y += self.settings.dude_speed
        if self.moving_up and self.rect.top > self.screen_rect.top:
            self.y -= self.settings.dude_speed

        self.rect.x = self.x
        self.rect.y = self.y

    def blitme(self):
        """Draw the dude at its current location"""
        self.screen.blit(self.image, self.rect)
