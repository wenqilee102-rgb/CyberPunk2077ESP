using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameweaponeventsSetAmmoCountEvent : redEvent
	{
		private gameItemID _ammoTypeID;
		private CUInt32 _count;

		[Ordinal(0)] 
		[RED("ammoTypeID")] 
		public gameItemID AmmoTypeID
		{
			get => GetProperty(ref _ammoTypeID);
			set => SetProperty(ref _ammoTypeID, value);
		}

		[Ordinal(1)] 
		[RED("count")] 
		public CUInt32 Count
		{
			get => GetProperty(ref _count);
			set => SetProperty(ref _count, value);
		}

		public gameweaponeventsSetAmmoCountEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
