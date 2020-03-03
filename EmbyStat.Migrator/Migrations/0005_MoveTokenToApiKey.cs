﻿using EmbyStat.Migrator.Models;

namespace EmbyStat.Migrator.Migrations
{
    [Migration(5)]
    public class MoveTokenToApiKey : Migration
    {
        public override void Up()
        {
            UserSettings.MediaServer.ApiKey = UserSettings.MediaServer.AccessToken;
        }
    }
}
