using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RipperdocPerkTooltip : AGenericTooltipController
	{
		private inkTextWidgetReference _perkName;
		private inkImageWidgetReference _perkIcon;
		private CName _skeletonPerkLocKey;
		private CName _handsPerkLocKey;
		private CName _skeletonPerkIconName;
		private CName _handsPerkIconName;

		[Ordinal(2)] 
		[RED("perkName")] 
		public inkTextWidgetReference PerkName
		{
			get => GetProperty(ref _perkName);
			set => SetProperty(ref _perkName, value);
		}

		[Ordinal(3)] 
		[RED("perkIcon")] 
		public inkImageWidgetReference PerkIcon
		{
			get => GetProperty(ref _perkIcon);
			set => SetProperty(ref _perkIcon, value);
		}

		[Ordinal(4)] 
		[RED("skeletonPerkLocKey")] 
		public CName SkeletonPerkLocKey
		{
			get => GetProperty(ref _skeletonPerkLocKey);
			set => SetProperty(ref _skeletonPerkLocKey, value);
		}

		[Ordinal(5)] 
		[RED("handsPerkLocKey")] 
		public CName HandsPerkLocKey
		{
			get => GetProperty(ref _handsPerkLocKey);
			set => SetProperty(ref _handsPerkLocKey, value);
		}

		[Ordinal(6)] 
		[RED("skeletonPerkIconName")] 
		public CName SkeletonPerkIconName
		{
			get => GetProperty(ref _skeletonPerkIconName);
			set => SetProperty(ref _skeletonPerkIconName, value);
		}

		[Ordinal(7)] 
		[RED("handsPerkIconName")] 
		public CName HandsPerkIconName
		{
			get => GetProperty(ref _handsPerkIconName);
			set => SetProperty(ref _handsPerkIconName, value);
		}

		public RipperdocPerkTooltip(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
