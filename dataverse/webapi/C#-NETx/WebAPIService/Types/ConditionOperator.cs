﻿using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerApps.Samples.Types
{
    [Serializable]
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ConditionOperator
    {
        Equal,
        NotEqual,
        GreaterThan,
        LessThan,
        Like,
        NotLike,
        In,
        NotIn,
        Between,
        NotBetween,
        Null,
        NotNull,
        Yesterday,
        Today,
        Tomorrow,
        Last7Days,
        Next7Days,
        LastWeek,
        ThisWeek,
        NextWeek,
        LastMonth,
        ThisMonth,
        NextMonth,
        On,
        OnOrBefore,
        OnOrAfter,
        LastYear,
        ThisYear,
        NextYear,
        LastXHours,
        NextXHours,
        LastXDays,
        NextXDays,
        LastXWeeks,
        NextXWeeks,
        LastXMonths,
        NextXMonths,
        LastXYears,
        NextXYears,
        EqualUserId,
        NotEqualUserId,
        ChildOf,
        Mask,
        NotMask,
        MasksSelect,
        Contains,
        DoesNotContain,
        EqualUserLanguage,
        NotOn,
        OlderThanXMonths,
        BeginsWith,
        DoesNotBeginWith,
        EndsWith,
        DoesNotEndWith,
        ThisFiscalYear,
        ThisFiscalPeriod,
        NextFiscalYear,
        NextFiscalPeriod,
        LastFiscalYear,
        LastFiscalPeriod,
        LastXFiscalPeriods,
        InFiscalYear,
        InFiscalPeriod,
        InFiscalPeriodAndYear,
        InOrAfterFiscalPeriodAndYear,
        EqualUserTeams,
        EqualUserOrUserTeams,
        Under,
        NotUnder,
        UnderOrEqual,
        Above,
        AboveOrEqual,
        EqualUserOrUserHierarchy,
        EqualUserOrUserHierarchyAndTeams,
        OlderThanXYears,
        OlderThanXWeeks,
        OlderThanXDays,
        OlderThanXHours,
        OlderThanXMinutes,
        ContainsValues,
        DoesNotContainValues,
        EqualRoleBusinessId

    }
}
