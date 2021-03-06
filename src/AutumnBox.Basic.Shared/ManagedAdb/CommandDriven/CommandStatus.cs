﻿namespace AutumnBox.Basic.ManagedAdb.CommandDriven
{
    /// <summary>
    /// 命令执行状态
    /// </summary>
    public enum CommandStatus
    {
        /// <summary>
        /// 准备
        /// </summary>
        Ready,
        /// <summary>
        /// 正在执行
        /// </summary>
        Executing,
        /// <summary>
        /// 成功
        /// </summary>
        Succeeded,
        /// <summary>
        /// 失败
        /// </summary>
        Failed
    }
}
