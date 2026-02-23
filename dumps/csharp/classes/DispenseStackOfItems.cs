using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DispenseStackOfItems : redEvent
	{
		private TweakDBID _item;
		private CInt32 _amount;

		[Ordinal(0)] 
		[RED("item")] 
		public TweakDBID Item
		{
			get => GetProperty(ref _item);
			set => SetProperty(ref _item, value);
		}

		[Ordinal(1)] 
		[RED("amount")] 
		public CInt32 Amount
		{
			get => GetProperty(ref _amount);
			set => SetProperty(ref _amount, value);
		}

		public DispenseStackOfItems(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
