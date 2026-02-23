using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UI_HUDProgressBarDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Variant _timerID;
		private gamebbScriptID_String _header;
		private gamebbScriptID_String _bottomText;
		private gamebbScriptID_String _completedText;
		private gamebbScriptID_String _failedText;
		private gamebbScriptID_Bool _active;
		private gamebbScriptID_Float _progress;
		private gamebbScriptID_Float _progressBump;
		private gamebbScriptID_Variant _messageType;

		[Ordinal(0)] 
		[RED("TimerID")] 
		public gamebbScriptID_Variant TimerID
		{
			get => GetProperty(ref _timerID);
			set => SetProperty(ref _timerID, value);
		}

		[Ordinal(1)] 
		[RED("Header")] 
		public gamebbScriptID_String Header
		{
			get => GetProperty(ref _header);
			set => SetProperty(ref _header, value);
		}

		[Ordinal(2)] 
		[RED("BottomText")] 
		public gamebbScriptID_String BottomText
		{
			get => GetProperty(ref _bottomText);
			set => SetProperty(ref _bottomText, value);
		}

		[Ordinal(3)] 
		[RED("CompletedText")] 
		public gamebbScriptID_String CompletedText
		{
			get => GetProperty(ref _completedText);
			set => SetProperty(ref _completedText, value);
		}

		[Ordinal(4)] 
		[RED("FailedText")] 
		public gamebbScriptID_String FailedText
		{
			get => GetProperty(ref _failedText);
			set => SetProperty(ref _failedText, value);
		}

		[Ordinal(5)] 
		[RED("Active")] 
		public gamebbScriptID_Bool Active
		{
			get => GetProperty(ref _active);
			set => SetProperty(ref _active, value);
		}

		[Ordinal(6)] 
		[RED("Progress")] 
		public gamebbScriptID_Float Progress
		{
			get => GetProperty(ref _progress);
			set => SetProperty(ref _progress, value);
		}

		[Ordinal(7)] 
		[RED("ProgressBump")] 
		public gamebbScriptID_Float ProgressBump
		{
			get => GetProperty(ref _progressBump);
			set => SetProperty(ref _progressBump, value);
		}

		[Ordinal(8)] 
		[RED("MessageType")] 
		public gamebbScriptID_Variant MessageType
		{
			get => GetProperty(ref _messageType);
			set => SetProperty(ref _messageType, value);
		}

		public UI_HUDProgressBarDef(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
