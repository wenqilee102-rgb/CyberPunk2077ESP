using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AccessBreach : PuppetAction
	{
		private CInt32 _attempt;
		private CString _networkName;
		private CInt32 _npcCount;
		private CBool _isRemote;
		private CBool _isSuicide;

		[Ordinal(39)] 
		[RED("attempt")] 
		public CInt32 Attempt
		{
			get => GetProperty(ref _attempt);
			set => SetProperty(ref _attempt, value);
		}

		[Ordinal(40)] 
		[RED("networkName")] 
		public CString NetworkName
		{
			get => GetProperty(ref _networkName);
			set => SetProperty(ref _networkName, value);
		}

		[Ordinal(41)] 
		[RED("npcCount")] 
		public CInt32 NpcCount
		{
			get => GetProperty(ref _npcCount);
			set => SetProperty(ref _npcCount, value);
		}

		[Ordinal(42)] 
		[RED("isRemote")] 
		public CBool IsRemote
		{
			get => GetProperty(ref _isRemote);
			set => SetProperty(ref _isRemote, value);
		}

		[Ordinal(43)] 
		[RED("isSuicide")] 
		public CBool IsSuicide
		{
			get => GetProperty(ref _isSuicide);
			set => SetProperty(ref _isSuicide, value);
		}

		public AccessBreach(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
