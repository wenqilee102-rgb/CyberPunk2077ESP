using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DispenseStackRequest : MarketSystemRequest
	{
		private Vector4 _position;
		private gameItemID _itemID;
		private CInt32 _amount;
		private CBool _shouldPay;
		private CBool _bypassStock;

		[Ordinal(2)] 
		[RED("position")] 
		public Vector4 Position
		{
			get => GetProperty(ref _position);
			set => SetProperty(ref _position, value);
		}

		[Ordinal(3)] 
		[RED("itemID")] 
		public gameItemID ItemID
		{
			get => GetProperty(ref _itemID);
			set => SetProperty(ref _itemID, value);
		}

		[Ordinal(4)] 
		[RED("amount")] 
		public CInt32 Amount
		{
			get => GetProperty(ref _amount);
			set => SetProperty(ref _amount, value);
		}

		[Ordinal(5)] 
		[RED("shouldPay")] 
		public CBool ShouldPay
		{
			get => GetProperty(ref _shouldPay);
			set => SetProperty(ref _shouldPay, value);
		}

		[Ordinal(6)] 
		[RED("bypassStock")] 
		public CBool BypassStock
		{
			get => GetProperty(ref _bypassStock);
			set => SetProperty(ref _bypassStock, value);
		}

		public DispenseStackRequest(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
