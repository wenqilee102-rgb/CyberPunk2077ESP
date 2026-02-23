using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ClothingSetIconsPopupData : inkGameNotificationData
	{
		private TweakDBID _iconID;
		private CBool _iconChanged;
		private CArray<TweakDBID> _iconIDs;

		[Ordinal(7)] 
		[RED("IconID")] 
		public TweakDBID IconID
		{
			get => GetProperty(ref _iconID);
			set => SetProperty(ref _iconID, value);
		}

		[Ordinal(8)] 
		[RED("IconChanged")] 
		public CBool IconChanged
		{
			get => GetProperty(ref _iconChanged);
			set => SetProperty(ref _iconChanged, value);
		}

		[Ordinal(9)] 
		[RED("IconIDs")] 
		public CArray<TweakDBID> IconIDs
		{
			get => GetProperty(ref _iconIDs);
			set => SetProperty(ref _iconIDs, value);
		}

		public ClothingSetIconsPopupData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
