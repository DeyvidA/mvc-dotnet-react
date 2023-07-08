// App Layout with Chakra UI

import React, { Component, useEffect, useState } from "react";
import { Route } from "react-router";
import { Box, Flex, Heading, Text, Button } from "@chakra-ui/react";

const AppLayout = ({ children }) => {
  return (
    <Box p={4}>
      <Flex justifyContent="space-between" alignItems="center" mb={8}>
        <Heading as="h1" size="xl">
          Mi Aplicación
        </Heading>
        <Button colorScheme="blue">Botón</Button>
      </Flex>

      <Box>
        <Text fontSize="xl" mb={4}>
          Título de sección
        </Text>

        <Flex justifyContent="space-between" alignItems="center">
          {children}
        </Flex>
      </Box>
    </Box>
  );
};

export default AppLayout;
