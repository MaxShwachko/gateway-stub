﻿using GatewayStub.Api.Models.Dto;
using GatewayStub.ByteFormatter;

namespace GatewayStub.Domain.Models.Dao
{
    public class ProductsDao
    {
        public NetList<EquipmentPurchaseDto> EquipmentProducts;
        public NetList<PromoRewardDto> PromoCodeRewards;
        public NetList<HeroPurchaseDto> HeroProducts;
        public bool ProductPurchaseSuccess;
    }
}