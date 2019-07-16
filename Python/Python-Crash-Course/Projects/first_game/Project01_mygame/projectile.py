import pygame
from pygame.sprite import Sprite


class Projectile(Sprite):
    """Manage shots fired from the dude"""

    def __init__(self, ws_game):
        """Create bullet object at the dude's location"""
        super().__init__()
        self.screen = ws_game.screen
        self.settings = ws_game.settings
        self.colour = self.settings.projectile_colour

        # Create a projectile rect at (0,0) then set position
        self.rect = pygame.Rect(
            0, 0, self.settings.projectile_width,
            self.settings.projectile_height)
        self.rect.center = ws_game.dude.rect.center

        # Store the bullets position as decimal
        self.y = float(self.rect.y)
        self.x = float(self.rect.x)

        self.shooting_right = False
        self.shooting_left = False
        self.shooting_up = False
        self.shooting_down = False

    def update(self, ws_game):
        """Move the projectiles across the screen"""

        if self.shooting_down:
            self.y += self.settings.projectile_speed
        elif self.shooting_up:
            self.y -= self.settings.projectile_speed
        elif self.shooting_left:
            self.x -= self.settings.projectile_speed
        elif self.shooting_right:
            self.x += self.settings.projectile_speed

        self.rect.y = self.y
        self.rect.x = self.x

    def draw_projectile(self):
        pygame.draw.rect(self.screen, self.colour, self.rect)
