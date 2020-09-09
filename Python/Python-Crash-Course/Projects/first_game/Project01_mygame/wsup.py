import pygame
import sys

from wsupsettings import Settings
from dude import Dude
from projectile import Projectile


class WSUP:
    """Overall class management"""

    def __init__(self):
        """Start the game and create resources"""
        pygame.init()
        # Screen settings
        self.settings = Settings()
        self.screen = pygame.display.set_mode(
            (self.settings.screen_width, self.settings.screen_height))
        pygame.display.set_caption("White Surpremist")

        # Dude settings
        self.dude = Dude(self)

        # Projectile settings
        self.projectiles = pygame.sprite.Group()
        self.projectile_direction = 'up'

    def play_game(self):
        while True:
            self._check_events()
            self.dude.update()
            self._update_projectiles()
            self._update_screen()

    def _check_events(self):
        """Check for keypresses/mouse events"""
        for event in pygame.event.get():
            if event.type == pygame.QUIT:
                sys.exit()
            elif event.type == pygame.KEYDOWN:
                self._check_keydown_events(event)
            elif event.type == pygame.KEYUP:
                self._check_keyup_events(event)

    def _check_keydown_events(self, event):
        """Method for key presses"""
        if event.key == pygame.K_RIGHT:
            self.dude.moving_right = True
            self.projectile_direction = 'right'
        elif event.key == pygame.K_LEFT:
            self.dude.moving_left = True
            self.projectile_direction = 'left'
        elif event.key == pygame.K_UP:
            self.dude.moving_up = True
            self.projectile_direction = 'up'
        elif event.key == pygame.K_DOWN:
            self.dude.moving_down = True
            self.projectile_direction = 'down'
        elif event.key == pygame.K_SPACE:
            self._fire_projectile()
        elif event.key == pygame.K_q:
            sys.exit()

    def _check_keyup_events(self, event):
        """Method for key releases"""
        if event.key == pygame.K_RIGHT:
            self.dude.moving_right = False
        elif event.key == pygame.K_LEFT:
            self.dude.moving_left = False
        elif event.key == pygame.K_UP:
            self.dude.moving_up = False
        elif event.key == pygame.K_DOWN:
            self.dude.moving_down = False

    def _fire_projectile(self):
        """Method to create projectiles in the projectiles group"""
        if len(self.projectiles) < self.settings.max_projectiles:
            new_projectile = Projectile(self)
            if self.projectile_direction == 'up':
                new_projectile.shooting_up = True
            elif self.projectile_direction == 'down':
                new_projectile.shooting_down = True
            elif self.projectile_direction == 'left':
                new_projectile.shooting_left = True
            elif self.projectile_direction == 'right':
                new_projectile.shooting_right = True
            self.projectiles.add(new_projectile)

    def _update_projectiles(self):
        """Update postion of projectiles and remove old ones"""
        self.projectiles.update(self)

        # Remove bullets that are off screen
        for projectile in self.projectiles.copy():
            if projectile.rect.bottom <= 0:
                self.projectiles.remove(projectile)
            if projectile.rect.left <= 0:
                self.projectiles.remove(projectile)
            if projectile.rect.right >= self.settings.screen_width:
                self.projectiles.remove(projectile)
            if projectile.rect.top >= self.settings.screen_height:
                self.projectiles.remove(projectile)
            # print(len(self.projectiles))

    def _update_screen(self):
        """Updates background colour, sprite, and screen"""
        self.screen.fill(self.settings.bg_colour)
        self.dude.blitme()
        for projectile in self.projectiles.sprites():
            projectile.draw_projectile()

        pygame.display.flip()


if __name__ == '__main__':
    ws = WSUP()
    ws.play_game()
