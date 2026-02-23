using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class HoloAudioCallLogicController : inkWidgetLogicController
	{
		private inkWidgetReference _avatarControllerRef;
		private inkWidgetReference _holder;
		private wCHandle<HudPhoneAvatarController> _avatarController;
		private wCHandle<gameObject> _owner;

		[Ordinal(1)] 
		[RED("AvatarControllerRef")] 
		public inkWidgetReference AvatarControllerRef
		{
			get => GetProperty(ref _avatarControllerRef);
			set => SetProperty(ref _avatarControllerRef, value);
		}

		[Ordinal(2)] 
		[RED("Holder")] 
		public inkWidgetReference Holder
		{
			get => GetProperty(ref _holder);
			set => SetProperty(ref _holder, value);
		}

		[Ordinal(3)] 
		[RED("AvatarController")] 
		public wCHandle<HudPhoneAvatarController> AvatarController
		{
			get => GetProperty(ref _avatarController);
			set => SetProperty(ref _avatarController, value);
		}

		[Ordinal(4)] 
		[RED("Owner")] 
		public wCHandle<gameObject> Owner
		{
			get => GetProperty(ref _owner);
			set => SetProperty(ref _owner, value);
		}

		public HoloAudioCallLogicController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
