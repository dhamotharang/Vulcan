﻿using System;
using System.Collections.Generic;
using DAL.Vulcan.Mongo.DocClass.Quotes;
using DAL.Vulcan.Mongo.Quotes;
using Vulcan.IMetal.Queries.StockItems;

namespace DAL.Vulcan.Mongo.Models
{
    public class QuoteMachinedPartModel
    {
        public string Application { get; set; } = string.Empty;
        public string UserId { get; set; } = string.Empty;
        public string Id { get; set; }
        public string Coid { get; set; }
        public ProductMaster MachinedPart { get; set; }
        public StockItemsAdvancedQuery MachinedPartFromCacheValue { get; set; }
        public decimal PieceWeightLbs { get; set; }
    
        public decimal PieceWeightKilos { get; set; }

        public decimal PieceCost { get; set; }
    
        public decimal PiecePrice { get; set; }
        public decimal PiecePriceOverride { get; set; }

        public string DisplayCurrency { get; set; } 
        public decimal ExchangeRate { get; set; } 
        public int Pieces { get; set; }
        public decimal Margin { get; set; }
        public decimal MarginOverride { get; set; }
        
        public decimal TotalCost { get; set; }
        public decimal TotalPrice { get; set; }
    
        public string Label { get; set; }
        public QuoteMachinedPartModel()
        {
        }


        public QuoteMachinedPartModel(string application, string userId, string coid, int stockItemId, string displayCurrency)
        {

            var machinePartCostValue =
                new MachinedPartCostPriceValue(coid, stockItemId, 1, displayCurrency);
            
            Application = application;
            UserId = userId;
            Id = machinePartCostValue.Id.ToString();
            Coid = machinePartCostValue.Coid;
            MachinedPart = machinePartCostValue.MachinedPart;
            MachinedPartFromCacheValue = machinePartCostValue.MachinedPartFromCacheValue;
            PieceWeightLbs = machinePartCostValue.PieceWeightLbs;
            PieceWeightKilos = machinePartCostValue.PieceWeightKilos;
            DisplayCurrency = machinePartCostValue.DisplayCurrency;
            ExchangeRate = machinePartCostValue.ExchangeRate;
            Pieces = machinePartCostValue.Pieces;
            PieceCost = machinePartCostValue.PieceCost;
            PiecePrice = machinePartCostValue.PiecePrice;
            PiecePriceOverride = machinePartCostValue.PiecePriceOverride;
            Margin = 0;
            MarginOverride = machinePartCostValue.MarginOverride;
            TotalCost = machinePartCostValue.TotalCost;
            TotalPrice = machinePartCostValue.TotalPrice;
            Label = machinePartCostValue.MachinedPart.ProductCode;
        }

        public QuoteMachinedPartModel(string application, string userId, MachinedPartCostPriceValue value)
        {
            value.Calculate();

            Id = value.Id.ToString();
            Application = application;
            UserId = userId;
            Coid = value.Coid;
            MachinedPart = value.MachinedPart;
            MachinedPartFromCacheValue = value.MachinedPartFromCacheValue;
            DisplayCurrency = value.DisplayCurrency;
            ExchangeRate = value.ExchangeRate;
            Margin = value.Margin;
            MarginOverride = value.MarginOverride;
            PieceCost = value.PieceCost;
            PiecePrice = value.PiecePrice;
            PiecePriceOverride = value.PiecePriceOverride;
            Pieces = value.Pieces;
            TotalCost = value.TotalCost;
            TotalPrice = value.TotalPrice;
            PieceWeightLbs = value.PieceWeightLbs;
            PieceWeightKilos = value.PieceWeightKilos;
            Label = value.Label;
        }

        public MachinedPartCostPriceValue GetMachinedPartCostPriceValueFromModel()
        {
            var result = new MachinedPartCostPriceValue()
            {
                Id = Guid.Parse(Id),
                Coid = Coid,
                Pieces = Pieces,
                DisplayCurrency = DisplayCurrency,
                MachinedPart = MachinedPart,
                MachinedPartFromCacheValue = MachinedPartFromCacheValue,
                PiecePriceOverride = PiecePriceOverride,
                MarginOverride = MarginOverride,
                Label = Label
            };
            result.Calculate();
            return result;
        }

        public static QuoteMachinedPartModel Calculate(QuoteMachinedPartModel model)
        {
            var value = model.GetMachinedPartCostPriceValueFromModel();
            value.Calculate();
            return new QuoteMachinedPartModel(model.Application, model.UserId, value);
        }

    }
}