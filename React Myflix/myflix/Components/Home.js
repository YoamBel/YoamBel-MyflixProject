import React, { useState,useEffect } from 'react';
import { StyleSheet, Text, View,SafeAreaView,ActivityIndicator } from 'react-native';
import TabNavTopMovie from './Header/TabNavTopMovie';



const Home = () =>{

    return (
          <TabNavTopMovie/>
    );
  }
  
  const styles = StyleSheet.create({
    container: {
     backgroundColor:'red'
    },
  });
  
  export default  Home;