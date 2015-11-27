/*==============================================================*/
/* DBMS name:      MySQL 5.0                                    */
/* Created on:     11/27/2015 20:38:11                          */
/*==============================================================*/


drop table if exists Business_TransFlow;

drop table if exists Sys_Store;

drop table if exists Sys_StoreSN;

drop table if exists Sys_User;

/*==============================================================*/
/* Table: Business_TransFlow                                    */
/*==============================================================*/
create table Business_TransFlow
(
   ID                   char(36),
   SN                   varchar(64),
   Phone                varchar(16),
   RunningNo            varchar(64),
   ExcTime              datetime,
   ExcSource            varchar(32),
   NetPay               decimal(11,2) comment '应付',
   Payable              decimal(11,2) comment '实付',
   Handling             decimal(11,2) comment '手续费',
   Statue               varchar(16),
   BankRunningNo        varchar(128),
   Creator              varchar(32),
   CreatorID            char(36),
   CreatedTime          datetime
);

alter table Business_TransFlow comment '交易流水数据';

/*==============================================================*/
/* Table: Sys_Store                                             */
/*==============================================================*/
create table Sys_Store
(
   ID                   char(36),
   Name                 varchar(64),
   Phone                varchar(16),
   Creator              varchar(32),
   CreatorID            char(36),
   CreatedTime          datetime
);

alter table Sys_Store comment '门店信息';

/*==============================================================*/
/* Table: Sys_StoreSN                                           */
/*==============================================================*/
create table Sys_StoreSN
(
   ID                   char(36),
   StoreID              char(36),
   Code                 varchar(64),
   Status               tinyint comment '1 有效
            2 无效',
   Creator              varchar(32),
   CreatorID            char(36),
   CreatedTime          datetime
);

alter table Sys_StoreSN comment '门店机器码信息';

/*==============================================================*/
/* Table: Sys_User                                              */
/*==============================================================*/
create table Sys_User
(
   ID                   char(36),
   LoginName            varchar(32),
   Name                 varchar(64),
   Password             varchar(64),
   Phone                varchar(16),
   StoreID              char(36),
   Status               tinyint comment '1 有效
            2 无效',
   Creator              varchar(32),
   CreatorID            char(36),
   CreatedTime          datetime
);

alter table Sys_User comment '用户信息';

