﻿using SaasEcom.Data.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SaasEcom.Data.DataServices.Interfaces
{
    public interface ISubscriptionDataService
    {
        Task<Subscription> SubscribeUserAsync(ApplicationUser user, string planId, int? trialPeriodInDays = null);
        Task<List<Subscription>> UserSubscriptionsAsync(string userId);
        Task<Subscription> UserActiveSubscriptionAsync(string userId);
        Task<List<Subscription>> UserActiveSubscriptionsAsync(string userId);
        Task EndSubscriptionAsync(int subscriptionId);
        Task UpdateSubscriptionAsync(Subscription subscription);
    }
}