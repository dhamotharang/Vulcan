﻿using System.Linq;
using DAL.Vulcan.Mongo.DocClass.CRM;
using DAL.Vulcan.Mongo.Helpers;
using Vulcan.WebApi2.Hubs;

namespace Vulcan.WebApi2.Helpers
{
    public class HelperTeamHub : IHelperTeamHub
    {
        private readonly ITeamHub _teamHub;

        public HelperTeamHub(ITeamHub teamHub)
        {
            _teamHub = teamHub;
        }

        public void RefreshNotificationsForUser(CrmUserRef crmUserRef)
        {
            var crmUser = crmUserRef.AsCrmUser();
            var lastNotification = crmUser.Notifications.Select(x => x.AsNotification()).OrderByDescending(x => x.NotificationDate)
                .FirstOrDefault();
            if (lastNotification == null) return;
            _teamHub.SendRefreshNotificationsForUser(crmUserRef,lastNotification.Label);
        }


        public void RefreshActionsForUser(CrmUserRef crmUserRef)
        {
            _teamHub.SendRefreshActionsForUser(crmUserRef);
        }

    }
}