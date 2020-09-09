class Settings:
    """This class stores all the settings for WSUP"""

    def __init__(self):
        """Initialize game settings"""
        # Window Settings
        self.screen_width = 800
        self.screen_height = 600
        self.bg_colour = (128, 128, 128)

        # Dude Settings
        self.dude_speed = 0.7

        # Projectile settings
        self.projectile_speed = 1.0
        self.projectile_width = 5
        self.projectile_height = 5
        self.projectile_colour = (60, 60, 60)
        self.max_projectiles = 5
