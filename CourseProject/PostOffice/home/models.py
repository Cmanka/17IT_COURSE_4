from datetime import date

from django.db import models


class PostOffice(models.Model):
    name = models.CharField(verbose_name='Name', max_length=100)
    address = models.CharField(verbose_name='Address', max_length=100)

    def __str__(self):
        return self.name

    class Meta:
        verbose_name = 'Post office'
        verbose_name_plural = 'Post offices'


class Position(models.Model):
    name = models.CharField(verbose_name='Name', max_length=50)
    salary = models.DecimalField(verbose_name='Salary', max_digits=9, decimal_places=2)

    def __str__(self):
        return self.name

    class Meta:
        verbose_name = 'Position'
        verbose_name_plural = 'Positions'


class Employee(models.Model):
    firstName = models.CharField(verbose_name='First name', max_length=50)
    lastName = models.CharField(verbose_name='Last name', max_length=50)
    middleName = models.CharField(verbose_name='Middle name', max_length=50)
    position = models.ForeignKey('Position', on_delete=models.PROTECT)
    postOffice = models.ForeignKey('PostOffice', on_delete=models.PROTECT)

    def __str__(self):
        return f'{self.firstName}\n{self.lastName}\n{self.middleName}'

    class Meta:
        verbose_name = 'Employee'
        verbose_name_plural = 'Employees'


class PublishingHouse(models.Model):
    name = models.CharField(verbose_name='Name', max_length=50)
    address = models.CharField(verbose_name='Address', max_length=100)

    def __str__(self):
        return self.name;

    class Meta:
        verbose_name = 'Publishing House'
        verbose_name_plural = 'Publishing Houses'


class Publication(models.Model):
    name = models.CharField(verbose_name='Name', max_length=50)
    publishingHouse = models.ForeignKey('PublishingHouse', on_delete=models.PROTECT)

    def __str__(self):
        return self.name

    class Meta:
        verbose_name = 'Publication'
        verbose_name_plural = 'Publications'


class Release(models.Model):
    price = models.DecimalField(verbose_name='Price', max_digits=9, decimal_places=2)
    count = models.PositiveIntegerField(verbose_name='Count', default=1)
    publication = models.ForeignKey('Publication', on_delete=models.PROTECT)
    postOffice = models.ForeignKey('PostOffice', on_delete=models.PROTECT)

    def __str__(self):
        return f'{self.publication.name - self.count}'

    class Meta:
        verbose_name = 'Release'
        verbose_name_plural = 'Releases'


class Region(models.Model):
    index = models.PositiveIntegerField(verbose_name='Region Index')
    postOffice = models.ForeignKey('PostOffice', on_delete=models.PROTECT)

    def __str__(self):
        return self.index

    class Meta:
        verbose_name = 'Region'
        verbose_name_plural = 'Regions'


class House(models.Model):
    address = models.CharField(verbose_name='Address', max_length=100)
    region = models.ForeignKey('Region', on_delete=models.PROTECT)

    def __str__(self):
        return self.address

    class Meta:
        verbose_name = 'House'
        verbose_name_plural = 'Houses'


class Follower(models.Model):
    firstName = models.CharField(verbose_name='First name', max_length=50)
    lastName = models.CharField(verbose_name='Last name', max_length=50)
    middleName = models.CharField(verbose_name='Middle name', max_length=50)
    house = models.ForeignKey('House', on_delete=models.PROTECT)

    def __str__(self):
        return f'{self.firstName}\n{self.lastName}\n{self.middleName}'

    class Meta:
        verbose_name = 'Follower'
        verbose_name_plural = 'Followers'


class Subscription(models.Model):
    startDate = models.DateField(verbose_name='Subscription started', default=date.today)
    term = models.PositiveSmallIntegerField(verbose_name='Subscription term(month)', default=1)
    postOffice = models.ForeignKey('PostOffice', on_delete=models.PROTECT)
    publication = models.ForeignKey('Publication', on_delete=models.PROTECT)
    follower = models.ForeignKey('Follower', on_delete=models.PROTECT)

    def __str__(self):
        return f'{self.publication.name - self.term}'

    class Meta:
        verbose_name = 'Subscription'
        verbose_name_plural = 'Subscriptions'
