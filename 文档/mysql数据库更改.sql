alter table sline_member add column `pid` varchar(255) NOT NULL DEFAULT '0' after `mid`;

CREATE TABLE `sline_member_address`(
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `mid` int(11) NOT NULL COMMENT '会员id',
  `name` varchar(30) COLLATE utf8_bin DEFAULT NULL COMMENT '收货人姓名',
  `mobile` varchar(30) COLLATE utf8_bin DEFAULT NULL COMMENT '手机号码',
  `provid` int(11) DEFAULT '0' COMMENT '省份id',
  `province` varchar(50) COLLATE utf8_bin DEFAULT NULL COMMENT '省份',
  `cityid` int(11) DEFAULT '0' COMMENT '城市id',
  `city` varchar(50) COLLATE utf8_bin DEFAULT NULL COMMENT '城市',
  `countyid` int(11) DEFAULT '0' COMMENT '区县id',
  `county` varchar(50) COLLATE utf8_bin DEFAULT NULL COMMENT '区县',
  `addresshome` varchar(100) COLLATE utf8_bin DEFAULT NULL COMMENT '详细住址',
  `zip` varchar(20) COLLATE utf8_bin DEFAULT NULL COMMENT '邮编',
  `isdefault` int(3) DEFAULT '0' COMMENT '是否默认',
  `flag` int(3) DEFAULT '0' COMMENT '标识',
  PRIMARY KEY(`id`)
);

CREATE TABLE `sline_fenxiao_yongjin`(
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `grade` int(11) NOT NULL COMMENT '级别',
  `commision` decimal(10,3) DEFAULT NULL COMMENT '佣金比例',
  `remark` longtext COMMENT '备注说明',
  `isusing` int(3) DEFAULT '0' COMMENT '是否当前可用',
  `isinternal` int(3) DEFAULT '0' COMMENT '是否内部可用',
  `flag` int(3) DEFAULT '0' COMMENT '标识',
  `createtime` datetime default NULL COMMENT '创建时间',
  `createuser` int(11) default NULL COMMENT '创建人',
  `modifytime` datetime default NULL COMMENT '修改时间',
  `modifyuser` int(11) default NULL COMMENT '修改人',
  PRIMARY KEY (`id`)
);

CREATE TABLE `sline_region_province`(
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(100) COLLATE utf8_bin DEFAULT NULL COMMENT '名称',
  `alias` varchar(100) COLLATE utf8_bin DEFAULT NULL COMMENT '别名',
  `remark` longtext COMMENT '备注说明',
  PRIMARY KEY (`id`)
);

CREATE TABLE `sline_region_city`(
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `provid` int(1) DEFAULT '0' COMMENT '省id',
  `name` varchar(100) COLLATE utf8_bin DEFAULT NULL COMMENT '名称',
  `zip` varchar(20) COLLATE utf8_bin DEFAULT NULL COMMENT '邮编',
  `issubsite` int(3) DEFAULT '0' COMMENT '是否有子站',
  `remark` longtext COMMENT '备注说明',
  PRIMARY KEY (`id`)
);

CREATE TABLE `sline_region_county`(
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `cityid` int(1) DEFAULT '0' COMMENT '市id',
  `name` varchar(100) COLLATE utf8_bin DEFAULT NULL COMMENT '名称',
  `remark` longtext COMMENT '备注说明',
  PRIMARY KEY (`id`)
);