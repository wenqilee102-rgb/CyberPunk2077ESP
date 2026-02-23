using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TransmogMessageTooltipData : MessageTooltipData
	{
		private gameItemID _transmogItem;
		private CName _iconPath;
		private CBool _noIcon;

		[Ordinal(4)] 
		[RED("TransmogItem")] 
		public gameItemID TransmogItem
		{
			get => GetProperty(ref _transmogItem);
			set => SetProperty(ref _transmogItem, value);
		}

		[Ordinal(5)] 
		[RED("IconPath")] 
		public CName IconPath
		{
			get => GetProperty(ref _iconPath);
			set => SetProperty(ref _iconPath, value);
		}

		[Ordinal(6)] 
		[RED("NoIcon")] 
		public CBool NoIcon
		{
			get => GetProperty(ref _noIcon);
			set => SetProperty(ref _noIcon, value);
		}

		public TransmogMessageTooltipData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
