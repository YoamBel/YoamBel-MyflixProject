import React, { useState, useEffect } from 'react'
import { createStackNavigator } from '@react-navigation/stack';
import TabNavBot from './TabNavBot';
import { StyleSheet, Text, View,SafeAreaView,ActivityIndicator } from 'react-native';
import CardInformationOfMovie from '../Components/FormeCard/CardInformationOfMovie'
import Movie from '../Components/Movie';
import Home from '../Components/Home';
import ListNewMovie from '../Components/ListNewMovie';
import Download from '../Components/Download';
//import CardSearch from '../Components/FormeCard/CardSearch';
import SearchBar from '../Components/SearchBar';



const Stack = createStackNavigator();

const StackNav = () => {
    return (
        <Stack.Navigator  screenOptions={{
            headerShown: false
          }}>
            <Stack.Screen name= "TabNavBot" component={TabNavBot} />  
            <Stack.Screen name= "Movie" component={Movie} />
            <Stack.Screen name= "ListNewMovie" component={ListNewMovie} /> 
            <Stack.Screen name= "StackNav" component={StackNav} />
            <Stack.Screen name= "Download" component={Download} />
            <Stack.Screen name= "SearchBar" component={SearchBar} />        
        </Stack.Navigator>
    );
}
const styles = StyleSheet.create({
    container: {},
  });

export default  StackNav;