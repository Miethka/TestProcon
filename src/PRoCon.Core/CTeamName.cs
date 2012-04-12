﻿// Copyright 2010 Geoffrey 'Phogue' Green
// 
// http://www.phogue.net
//  
// This file is part of PRoCon Frostbite.
// 
// PRoCon Frostbite is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// PRoCon Frostbite is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with PRoCon Frostbite.  If not, see <http://www.gnu.org/licenses/>.
namespace PRoCon.Core
{
    using System;

    [Serializable]
    public class CTeamName
    {

        public CTeamName(string strMapFilename, int iTeamId, string strLocalizationKey, string strImageKey) {
            this.MapFilename = strMapFilename;
            this.TeamID = iTeamId;
            this.LocalizationKey = strLocalizationKey;
            this.ImageKey = strImageKey;
            this.Playlist = "";
        }

        public CTeamName(string strMapFilename, int iTeamId, string strLocalizationKey, string strImageKey, string playlist = "")
        {
            this.MapFilename = strMapFilename;
            this.TeamID = iTeamId;
            this.LocalizationKey = strLocalizationKey;
            this.ImageKey = strImageKey;
            this.Playlist = playlist;
        }

        public string MapFilename { get; private set; }

        public string Playlist { get; private set; }

        public int TeamID { get; private set; }

        public string LocalizationKey { get; private set; }

        public string ImageKey { get; private set; }
    }
}