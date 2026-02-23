using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PoliceSirenTimerRequest : gameScriptableSystemRequest
	{
		private CBool _red;
		private CBool _fast;
		private CBool _abort;

		[Ordinal(0)] 
		[RED("red")] 
		public CBool Red
		{
			get => GetProperty(ref _red);
			set => SetProperty(ref _red, value);
		}

		[Ordinal(1)] 
		[RED("fast")] 
		public CBool Fast
		{
			get => GetProperty(ref _fast);
			set => SetProperty(ref _fast, value);
		}

		[Ordinal(2)] 
		[RED("abort")] 
		public CBool Abort
		{
			get => GetProperty(ref _abort);
			set => SetProperty(ref _abort, value);
		}

		public PoliceSirenTimerRequest(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
