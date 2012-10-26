﻿namespace ShootR
{
    public class GameConfigurationManager
    {
        public GameConfigurationManager()
        {
            bulletConfig = new BulletConfiguration();
            gameConfig = new GameConfiguration();
            shipConfig = new ShipConfiguration();
            mapConfig = new MapConfiguration();
            screenConfig = new ScreenConfiguration();
            leaderboardConfig = new LeaderboardConfiguration();
            healthPackConfig = new HealthPackConfiguration();
        }

        // Bullet Configurations
        public BulletConfiguration bulletConfig { get; set; }

        // Game Configurations
        public GameConfiguration gameConfig { get; set; }

        // Ship Configurations
        public ShipConfiguration shipConfig { get; set; }

        // Map Configurations
        public MapConfiguration mapConfig { get; set; }

        // Screen Configurations
        public ScreenConfiguration screenConfig { get; set; }

        // Leaderboard Configurations
        public LeaderboardConfiguration leaderboardConfig { get; set; }

        // Powerup Configurations
        // HealthPack Configurations
        public HealthPackConfiguration healthPackConfig { get; set; }
    }
}