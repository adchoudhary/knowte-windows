﻿using System;
using System.Threading.Tasks;

namespace Knowte.Common.Services.Backup
{
    public interface IBackupService
    {
        bool Export(string exportLocation);
        bool Backup(string backupFile);
        bool Import(string backupFile);
        bool Restore(string backupFile);
        event EventHandler BackupRestored;
    }
}
