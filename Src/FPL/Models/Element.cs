namespace FPL.Models
{
    public record Element : PlayerStats
    {
        public int? ChanceOfPlayingNextRound { get; init; } = default!;
        public int? ChanceOfPlayingThisRound { get; init; } = default!;
        public int Code { get; init; } = default!;
        public int CostChangeEvent { get; init; } = default!;
        public int CostChangeEventFall { get; init; } = default!;
        public int CostChangeStart { get; init; } = default!;
        public int CostChangeStartFall { get; init; } = default!;
        public int DreamteamCount { get; init; } = default!;
        public int ElementType { get; init; } = default!;
        public string EpNext { get; init; } = default!;
        public string EpThis{ get; init; } = default!;
        public int EventPoints { get; init; } = default!;
        public string FirstName { get; init; } = default!;
        public string Form { get; init; } = default!;
        public int Id { get; init; } = default!;
        public bool InDreamteam { get; init; } = default!;
        public string News { get; init; } = default!;
        public string NewsAdded { get; init; } = default!;
        public int NowCost { get; init; } = default!;
        public string Photo { get; init; } = default!;
        public string PointsPerGame { get; init; } = default!;
        public string SecondName { get; init; } = default!;
        public string SelectedByPercent { get; init; } = default!;
        public bool Special { get; init; } = default!;
        public string SquadNumber { get; init; } = default!;
        public string Status { get; init; } = default!;
        public int Team { get; init; } = default!;
        public int TeamCode { get; init; } = default!;
        public int TotalPoints { get; init; } = default!;
        public int TransfersIn { get; init; } = default!;
        public int TransfersInEvent { get; init; } = default!;
        public int TransfersOut { get; init; } = default!;
        public int TransfersOutEvent { get; init; } = default!;
        public string ValueForm { get; init; } = default!;
        public string ValueSeason { get; init; } = default!;
        public string WebName { get; init; } = default!;
        public int InfluenceRank { get; init; } = default!;
        public int InfluenceRankType { get; init; } = default!;
        public int CreativityRank { get; init; } = default!;
        public int CreativityRankType { get; init; } = default!;
        public int ThreatRank { get; init; } = default!;
        public int ThreatRankType { get; init; } = default!;
        public int ICTIndexRank { get; init; } = default!;
        public int ICTIndexRankType { get; init; } = default!;
        public int? CornersAndIndirectFreekicksOrder { get; init; } = default!;
        public string CornersAndIndirectFreekicksText { get; init; } = default!;
        public int? DirectFreekicksOrder { get; init; } = default!;
        public string DirectFreekicksText { get; init; } = default!;
        public int? PenaltiesOrder { get; init; } = default!;
        public string PenaltiesText { get; init; } = default!;
    }
}
