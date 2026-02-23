using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldAudioSignpostTriggerNode : worldTriggerAreaNode
	{
		private CName _enterSignpost;
		private CName _exitSignpost;
		private CName _reEnterSignpost;
		private CName _preExitSignpost;
		private CFloat _exitCooldown;

		[Ordinal(7)] 
		[RED("enterSignpost")] 
		public CName EnterSignpost
		{
			get => GetProperty(ref _enterSignpost);
			set => SetProperty(ref _enterSignpost, value);
		}

		[Ordinal(8)] 
		[RED("exitSignpost")] 
		public CName ExitSignpost
		{
			get => GetProperty(ref _exitSignpost);
			set => SetProperty(ref _exitSignpost, value);
		}

		[Ordinal(9)] 
		[RED("reEnterSignpost")] 
		public CName ReEnterSignpost
		{
			get => GetProperty(ref _reEnterSignpost);
			set => SetProperty(ref _reEnterSignpost, value);
		}

		[Ordinal(10)] 
		[RED("preExitSignpost")] 
		public CName PreExitSignpost
		{
			get => GetProperty(ref _preExitSignpost);
			set => SetProperty(ref _preExitSignpost, value);
		}

		[Ordinal(11)] 
		[RED("exitCooldown")] 
		public CFloat ExitCooldown
		{
			get => GetProperty(ref _exitCooldown);
			set => SetProperty(ref _exitCooldown, value);
		}

		public worldAudioSignpostTriggerNode(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
