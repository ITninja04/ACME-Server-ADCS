﻿namespace TGIT.ACME.Protocol.IssuanceServices.ACDS
{
    public class ACDSOptions
    {
        public string CAServer { get; set; }
        public string? CAAttributes { get; set; }

        public bool AllowCNSuffix { get; set; }
    }
}
