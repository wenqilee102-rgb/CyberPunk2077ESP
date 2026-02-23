using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class QuickHackQueueItem : inkWidgetLogicController
	{
		private inkImageWidgetReference _icon;
		private CHandle<GameplayRoleMappinData> _data;
		private CHandle<inkanimProxy> _anim;

		[Ordinal(1)] 
		[RED("icon")] 
		public inkImageWidgetReference Icon
		{
			get => GetProperty(ref _icon);
			set => SetProperty(ref _icon, value);
		}

		[Ordinal(2)] 
		[RED("data")] 
		public CHandle<GameplayRoleMappinData> Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}

		[Ordinal(3)] 
		[RED("anim")] 
		public CHandle<inkanimProxy> Anim
		{
			get => GetProperty(ref _anim);
			set => SetProperty(ref _anim, value);
		}

		public QuickHackQueueItem(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
