-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='TRADITIONAL,ALLOW_INVALID_DATES';

-- -----------------------------------------------------
-- Schema mydb
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema mydb
-- -----------------------------------------------------
DROP SCHEMA IF EXISTS `Analisis1`;
CREATE SCHEMA IF NOT EXISTS `Analisis1` DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci ;
USE `Analisis1` ;

-- -----------------------------------------------------
-- Table `mydb`.`Usuario`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Analisis1`.`Usuario` (
  `Usuario` VARCHAR(100) NOT NULL COMMENT '',
  `contrasenia` VARCHAR(100) NOT NULL COMMENT '',
  `Nombre` VARCHAR(100) NOT NULL COMMENT '',
  `DPI` BIGINT NOT NULL COMMENT '',
  `Direccion` VARCHAR(300) NOT NULL COMMENT '',
  `Telefono` INT NULL COMMENT '',
  `No_Colegiado` INT NULL COMMENT '',
  `Activo` INT NOT NULL COMMENT '',
  `Rol` VARCHAR(45) NOT NULL COMMENT '',
  PRIMARY KEY (`Usuario`)  COMMENT '')
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`Estado`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Analisis1`.`Estado` (
  `Id_Estado` INT NOT NULL AUTO_INCREMENT COMMENT '',
  `Estado` VARCHAR(50) NOT NULL COMMENT '',
  PRIMARY KEY (`Id_Estado`)  COMMENT '')
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`Tipo_Caso`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Analisis1`.`Tipo_Caso` (
  `Id_Tipo` INT NOT NULL AUTO_INCREMENT COMMENT '',
  `Nombre` VARCHAR(45) NOT NULL COMMENT '',
  `Descripcion` VARCHAR(1000) NOT NULL COMMENT '',
  PRIMARY KEY (`Id_Tipo`)  COMMENT '')
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`Caso`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Analisis1`.`Caso` (
  `Id_Caso` INT NOT NULL AUTO_INCREMENT COMMENT '',
  `Descripcion` VARCHAR(1000) NOT NULL COMMENT '',
  `Fecha_Ingreso` DATETIME NOT NULL COMMENT '',
  `Usuario_Usuario` VARCHAR(100) NOT NULL COMMENT '',
  `Estado_Id_Estado` VARCHAR(50) NOT NULL COMMENT '',
  `Tipo_Caso_Id_Tipo` VARCHAR(50) NOT NULL COMMENT '',
  `Abogado` VARCHAR(50) NOT NULL COMMENT '',
  PRIMARY KEY (`Id_Caso`)  COMMENT '')
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`Documento`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Analisis1`.`Documento` (
  `Id_Documento` INT NOT NULL AUTO_INCREMENT COMMENT '',
  `Nombre` VARCHAR(200) NOT NULL COMMENT '',
  `Descripcion` VARCHAR(1000) NOT NULL COMMENT '',
  PRIMARY KEY (`Id_Documento`)  COMMENT '')
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`Caso_Documento`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Analisis1`.`Caso_Documento` (
  `Id` INT NOT NULL AUTO_INCREMENT COMMENT '',
  `Fecha` DATETIME NOT NULL COMMENT '',
  `Caso_Id_Caso` INT NOT NULL COMMENT '',
  `Documento_Id_Documento` INT NOT NULL COMMENT '',
  PRIMARY KEY (`Id`, `Caso_Id_Caso`, `Documento_Id_Documento`)  COMMENT '',
  INDEX `fk_Caso_Documento_Caso1_idx` (`Caso_Id_Caso` ASC)  COMMENT '',
  INDEX `fk_Caso_Documento_Documento1_idx` (`Documento_Id_Documento` ASC)  COMMENT '',
  CONSTRAINT `fk_Caso_Documento_Caso1`
    FOREIGN KEY (`Caso_Id_Caso`)
    REFERENCES `Analisis1`.`Caso` (`Id_Caso`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Caso_Documento_Documento1`
    FOREIGN KEY (`Documento_Id_Documento`)
    REFERENCES `Analisis1`.`Documento` (`Id_Documento`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`Multimedia`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Analisis1`.`Multimedia` (
  `Id_Multimedia` INT NOT NULL AUTO_INCREMENT COMMENT '',
  `Ruta` VARCHAR(300) NOT NULL COMMENT '',
  `Caso_Id_Caso` INT NOT NULL COMMENT '',
  PRIMARY KEY (`Id_Multimedia`)  COMMENT '',
  INDEX `fk_Multimedia_Caso1_idx` (`Caso_Id_Caso` ASC)  COMMENT '',
  CONSTRAINT `fk_Multimedia_Caso1`
    FOREIGN KEY (`Caso_Id_Caso`)
    REFERENCES `Analisis1`.`Caso` (`Id_Caso`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`Solicitud`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Analisis1`.`Solicitud` (
  `Id_solicitud` INT NOT NULL AUTO_INCREMENT COMMENT '',
  `Tipo` VARCHAR(100) NOT NULL COMMENT '',
  `Descripcion` VARCHAR(300) NOT NULL COMMENT '',
  `No_Colegiado_Abogado` INT NOT NULL COMMENT '',
  `DPI` BIGINT NOT NULL COMMENT '',
  `Estado_Solicitudl` VARCHAR(45) NOT NULL COMMENT '',
  PRIMARY KEY (`Id_solicitud`)  COMMENT '')
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
