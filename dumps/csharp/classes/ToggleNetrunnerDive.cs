using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ToggleNetrunnerDive : ActionBool
	{
		private CBool _skipMinigame;
		private CInt32 _attempt;
		private CBool _isRemote;

		[Ordinal(39)] 
		[RED("skipMinigame")] 
		public CBool SkipMinigame
		{
			get => GetProperty(ref _skipMinigame);
			set => SetProperty(ref _skipMinigame, value);
		}

		[Ordinal(40)] 
		[RED("attempt")] 
		public CInt32 Attempt
		{
			get => GetProperty(ref _attempt);
			set => SetProperty(ref _attempt, value);
		}

		[Ordinal(41)] 
		[RED("isRemote")] 
		public CBool IsRemote
		{
			get => GetProperty(ref _isRemote);
			set => SetProperty(ref _isRemote, value);
		}

		public ToggleNetrunnerDive(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
