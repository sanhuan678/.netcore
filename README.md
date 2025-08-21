# 工业设备监控系统

基于Winform和Modbus RTU协议实现的工业设备监控系统，用于实时采集温湿度/灯光数据，提供可视化展示、阈值报警和数据存储功能。

## 系统概述

本系统采用三层架构设计，结合Modbus RTU通信协议和SQL Server数据库，实现对工业设备的实时监控和数据管理。系统提供友好的用户界面，支持设备数据采集、状态控制、实时曲线展示和报警功能。

## 技术栈

- **前端界面**: Winform (C#) + DevExpress/自定义控件
- **通信协议**: Modbus RTU (使用NModbus库)
- **数据库**: SQL Server + Entity Framework ORM框架
- **系统架构**: 三层架构(表现层、业务逻辑层、数据访问层)

## 功能特性

### 1. 系统登录
- 基于数据库的用户名密码验证机制
- 安全的登录验证流程
- <img width="464" height="384" alt="image" src="https://github.com/user-attachments/assets/4459cc65-8048-4f86-80aa-25c98ff10a15" />


### 2. 设备数据采集
- 实时轮询采集设备温度、湿度、亮度状态
- 支持多从站设备通信
- 可配置串口通信参数(波特率、数据位、停止位、校验位)
- <img width="1025" height="718" alt="image" src="https://github.com/user-attachments/assets/bd4e82ad-9fda-422e-b634-070d45c0b03a" />
<img width="1915" height="1080" alt="image" src="https://github.com/user-attachments/assets/f0647705-a86e-4d46-95f4-7dca0a589811" />
<img width="938" height="562" alt="image" src="https://github.com/user-attachments/assets/ecac431e-182c-429b-8bd9-a46a05d8e032" />



### 3. 数据可视化
- 实时曲线展示温度、湿度变化趋势
- 设备状态直观显示(正常、高温、低温)
- 历史最高/最低温度记录显示
- <img width="1572" height="834" alt="image" src="https://github.com/user-attachments/assets/a7521059-ef6c-4812-9e54-8d719464a86e" />


### 4. 设备控制
- 通过Modbus写线圈指令控制5盏LED灯状态
- 支持向设备寄存器写入文本指令(如"请检修")
- 实时反馈设备控制结果
- <img width="1018" height="734" alt="image" src="https://github.com/user-attachments/assets/08656f95-8bd1-4001-8239-b48589c8c8f0" />


### 5. 报警管理
- 可配置温度、湿度阈值
- 自动触发报警状态并记录
- 视觉报警提示(颜色变化)
- <img width="1567" height="818" alt="image" src="https://github.com/user-attachments/assets/bd2cb2ce-32d7-47c9-86b5-541c872885c5" />
<img width="1575" height="787" alt="image" src="https://github.com/user-attachments/assets/16d8a906-c1b1-4ed3-a093-bb3b681c78ac" />


### 6. 数据存储
- 使用Entity Framework优化数据库操作
- 设备数据表设计包含设备ID、温度最高最低、湿度最大最小值、亮度最大最小值
- 支持历史数据查询和导出
- <img width="690" height="532" alt="image" src="https://github.com/user-attachments/assets/efe06bd4-d76a-4827-80e6-518aeb5038af" />


## 数据库设计

### 设备数据表结构
```sql
SELECT TOP (1000) [eid]
      ,[TemperatureLowM]
      ,[TemperatureHighM]
      ,[HumidtyLowM]
      ,[HumidtyHighM]
      ,[BrightnessLowM]
      ,[BrightnessHighM]
  FROM [equipmentMS].[dbo].[t_equipmentM]
```

## 安装与部署

###  prerequisites
- .NET Framework 4.7.2或更高版本
- SQL Server 2012或更高版本
- 支持Modbus RTU协议的设备或模拟器

### 安装步骤
1. 克隆或下载项目源代码
2. 使用Visual Studio打开解决方案文件(.sln)
3. 还原NuGet包依赖
4. 配置数据库连接字符串(在App.config中)
5. 执行数据库迁移或创建数据库表结构
6. 编译并运行项目

### 配置说明
1. 修改App.config中的数据库连接字符串
2. 配置串口通信参数(波特率、数据位、停止位等)
3. 设置设备从站地址和寄存器地址映射
4. 配置温度、湿度报警阈值

## 使用说明

1. **登录系统**: 输入正确的用户名和密码登录系统
2. **连接设备**: 配置串口参数并连接Modbus设备
3. **数据监控**: 查看实时数据曲线和设备状态
4. **设备控制**: 通过界面控制LED灯状态和发送文本指令
5. **报警管理**: 设置报警阈值并查看报警历史



## 开发注意事项

1. Modbus通信采用异步方式，避免UI线程阻塞
2. 数据库操作使用EF的异步方法提高响应性能
3. 采用依赖注入管理各层之间的依赖关系
4. 遵循三层架构设计原则，保持各层职责分离



## 许可证

本项目仅用于学习和研究目的，未经许可不得用于商业用途。



---

*注意：本项目需要配合Modbus RTU设备或模拟器使用，建议先使用Modbus模拟软件进行测试和开发。*
